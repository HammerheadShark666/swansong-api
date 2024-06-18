using Asp.Versioning;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[Authorize]
[Route("api/v{version:apiVersion}/members")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class MemberController : BaseController<Member>
{
    private readonly ILogger<MemberController> _logger;
    private readonly IMemberService _memberService;
    private readonly IMapper _mapper; 

    public MemberController(ILogger<MemberController> logger, IMemberService memberService,
                           IValidator<Member> validator, IMapper mapper) : base(validator)
    {
        _logger = logger;
        _mapper = mapper;
        _memberService = memberService;
    }

    [HttpGet("")]
    public async Task<ActionResult<List<MemberResponse>>> GetAllMembersAsync([FromQuery] PaginationFilter filter)
    {
        var paginationFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var members = await _memberService.GetAllAsync(paginationFilter);
        var totalRecords = await _memberService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<MemberResponse>(_mapper.Map<List<MemberResponse>>(members), paginationFilter, totalRecords));
    } 

    [HttpGet("random")]
    public async Task<ActionResult<List<MemberLookUpResponse>>> GetRandomMembersAsync()
    {
        var members = await _memberService.GetRandomAsync(EnvironmentVariablesHelper.NumberOfRandomRecords);
        return Ok(_mapper.Map<List<MemberLookUpResponse>>(members)); 
    }

    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<MemberResponse>>> GetSearchMembersAsync(string criteria)
    {
        var members = await _memberService.SearchByNameAsync(criteria);
        return Ok(_mapper.Map<List<MemberResponse>>(members));
    }

    [HttpGet("search-by-letter/{letter}")]
    public async Task<ActionResult<List<MemberResponse>>> GetSearchMembersByLetterAsync(string letter)
    {
        var members = await _memberService.SearchByLetterAsync(letter);
        return Ok(_mapper.Map<List<MemberResponse>>(members));
    }

    [HttpGet("member/{id}")]
    public async Task<ActionResult<MemberResponse>> GetMemberAsync(long id)
    {
        var member = await _memberService.GetAsync(id);
        return Ok(_mapper.Map<MemberResponse>(member));
    }

    [HttpGet("artist/{artistId}")]
    public async Task<ActionResult<List<MemberResponse>>> GetMembersForArtistAsync(long artistId)
    {
        var members = await _memberService.GetMembersByArtistAsync(artistId);
        return Ok(_mapper.Map<List<MemberResponse>>(members));
    } 

    [HttpPost("member/add")]
    public async Task<ActionResult<MemberActionResponse>> PostAddMemberAsync([FromBody] MemberAddRequest memberAddRequest)
    {
        Member member = _mapper.Map<Member>(memberAddRequest);

        var validationResult = await Validate(member, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedMember = await _memberService.AddAsync(member);

        return Ok(new MemberActionResponse(savedMember.Id));
    }

    [HttpPut("member/update")]
    public async Task<ActionResult> PutUpdateMemberAsync([FromBody] MemberUpdateRequest memberUpdateRequest)
    {
        Member member = _mapper.Map<Member>(memberUpdateRequest);

        var validationResult = await Validate(member, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _memberService.Update(member);

        return Ok();
    }

    [HttpDelete("member/{id}")]
    public async Task<ActionResult> DeleteMemberAsync(long id)
    { 
        await _memberService.DeleteAsync(await _memberService.GetAsync(id));

        return Ok();
    }

    [HttpPost("member/upload-photo/{id}")]
    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> SaveMemberPhotoAsync(long id)
    {
        if (Request.Form.Files.Count > 0)
        {
            var filename = await _memberService.UpdateMemberPhotoAsync(id, Request.Form.Files[0]);
            return Ok(new MemberPhotoActionResponse(filename));
        }
        else
        {
            return BadRequest(ConstantMessages.NoFileToSave);
        }
    }   
}