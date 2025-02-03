using Asp.Versioning;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
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
public class MemberController(ILogger<MemberController> logger,
                              IMemberService memberService,
                              IBirthPlaceService birthPlaceService,
                              IValidator<Member> validator,
                              IMapper mapper) : BaseController<Member>(validator)
{
    private readonly ILogger<MemberController> _logger = logger;
    private readonly IMemberService _memberService = memberService;
    private readonly IBirthPlaceService _birthPlaceService = birthPlaceService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("")]
    public async Task<ActionResult<List<MemberResponse>>> GetAllMembersAsync([FromQuery] PaginationFilter filter)
    {
        var paginationFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var members = await _memberService.GetAllAsync(paginationFilter);
        var totalRecords = await _memberService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<MemberResponse>(_mapper.Map<List<MemberResponse>>(members), paginationFilter, totalRecords));
    }

    [AllowAnonymous]
    [HttpGet("random")]
    public async Task<ActionResult<List<MemberLookUpResponse>>> GetRandomMembersAsync()
    {
        return Ok(_mapper.Map<List<MemberLookUpResponse>>(await _memberService.GetRandomAsync(EnvironmentVariablesHelper.NumberOfRandomRecords)));
    }

    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<MemberLookUpResponse>>> GetSearchMembersAsync(string criteria)
    {
        return Ok(_mapper.Map<List<MemberLookUpResponse>>(await _memberService.SearchByNameAsync(criteria)));
    }

    [HttpGet("search-by-letter/{letter}")]
    public async Task<ActionResult<List<MemberLookUpResponse>>> GetSearchMembersByLetterAsync(string letter)
    {
        return Ok(_mapper.Map<List<MemberLookUpResponse>>(await _memberService.SearchByLetterAsync(letter)));
    }

    [AllowAnonymous]
    [HttpGet("member/{id}")]
    public async Task<ActionResult<MemberResponse>> GetMemberAsync(long id)
    {
        return Ok(_mapper.Map<MemberResponse>(await _memberService.GetAsync(id)));
    }

    [HttpGet("artist/{artistId}")]
    public async Task<ActionResult<List<MemberResponse>>> GetMembersForArtistAsync(long artistId)
    {
        return Ok(_mapper.Map<List<MemberResponse>>(await _memberService.GetMembersByArtistAsync(artistId)));
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

        return Ok(new MemberActionResponse(member.Id));
    }

    [HttpPut("update/artist/assigned-to")]
    public ActionResult PutUpdateMemberArtistAssignedToAsync([FromBody] MemberUpdateArtistAssignedTo membersUpdateArtistAssignedTo)
    {
        _memberService.UpdateArtistAssignedTo(membersUpdateArtistAssignedTo);
        return Ok(new MemberActionResponse(membersUpdateArtistAssignedTo.ArtistId));
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

    [HttpGet("lookups/form")]
    public async Task<ActionResult<MemberLookUpsFormResponse>> GetLookupsForArtistFormAsync()
    {
        List<BirthPlaceResponse> birthPlaces = _mapper.Map<List<BirthPlaceResponse>>(await _birthPlaceService.GetAllAsync());
        return Ok(new MemberLookUpsFormResponse(birthPlaces));
    }

    [HttpPut("member/description/update")]
    public async Task<ActionResult> PutUpdateMemberDescriptionAsync([FromBody] MemberDescriptionUpdateRequest memberDescriptionUpdateRequest)
    {
        Member member = _mapper.Map<Member>(memberDescriptionUpdateRequest);

        var validationResult = await Validate(member, Constants.ValidationEventBeforeSaveDescription);
        if (validationResult != null)
            return BadRequest(validationResult);

        await _memberService.UpdateDescriptionAsync(memberDescriptionUpdateRequest.Id, memberDescriptionUpdateRequest.Description);

        return Ok(new MemberActionResponse(member.Id));
    }
}