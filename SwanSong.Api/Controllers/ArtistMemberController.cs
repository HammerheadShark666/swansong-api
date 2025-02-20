using Asp.Versioning;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/artist/members")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class ArtistMemberController(ILogger<ArtistMemberController> logger,
                                    IValidator<ArtistMember> validator,
                                    IArtistMemberService artistMemberService,
                                    IMapper mapper) : BaseController<ArtistMember>(validator)
{
    private readonly ILogger<ArtistMemberController> _logger = logger;
    private readonly IArtistMemberService _artistMemberService = artistMemberService;
    private readonly IMapper _mapper = mapper;

    [HttpPost("update")]
    public ActionResult PutUpdateMemberArtistAssignedToAsync([FromBody] MemberUpdateArtistAssignedTo membersUpdateArtistAssignedTo)
    {
        if (membersUpdateArtistAssignedTo.membersToRemove.Count == 0
                && membersUpdateArtistAssignedTo.MembersToAdd.Count == 0)
            return BadRequest(ConstantMessages.NoArtistMembersToUpdate);

        _artistMemberService.UpdateArtistAssignedTo(membersUpdateArtistAssignedTo);
        return Ok(new ArtistMemberActionResponse("Artist members have been updated."));
    }

    [HttpPut("member/update")]
    public async Task<ActionResult> PostArtistMemberUpdateAsync([FromBody] ArtistMemberAddRequest artistMemberAddRequest)
    {
        var member = _mapper.Map<ArtistMember>(artistMemberAddRequest);

        var validationResult = await Validate(member, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        await _artistMemberService.Update(member);

        return Ok(new ArtistMemberActionResponse("Artist member have been updated."));
    }

    [HttpPost("add")]
    public async Task<ActionResult> AddAsync([FromBody] ArtistMemberAddRequest artistMemberAddRequest)
    {
        ArtistMember artistMember = _mapper.Map<ArtistMember>(artistMemberAddRequest);

        var validationResult = await Validate(artistMember, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedArtistMember = await _artistMemberService.AddAsync(artistMember);

        return Ok(new ArtistMemberAddActionResponse(savedArtistMember.Id, savedArtistMember.Member.Id));
    }

    [HttpGet("{artistId}")]
    public async Task<ActionResult<List<ArtistMemberResponse>>> ArtistMembersAsync(long artistId)
    {
        return await _artistMemberService.GetMembersByArtistAsync(artistId);
    }

    [HttpDelete("member/{id}")]
    public async Task<ActionResult> DeleteArtistMemberAsync(long id)
    {
        await _artistMemberService.DeleteAsync(id);
        return Ok(new MemberActionResponse(id));
    }
}
