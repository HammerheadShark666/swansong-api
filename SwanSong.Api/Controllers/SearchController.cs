using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using static SwanSong.Domain.Dto.Search;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/search")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Consumes(MediaTypeNames.Application.Json)]
[Produces(MediaTypeNames.Application.Json)]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
public class SearchController(ILogger<AlbumController> logger,
                             IAlbumService albumService,
                             IArtistService artistService,
                             IMemberService memberService,
                             IMapper mapper,
                             IAlbumHelper albumHelper) : Controller
{
    private readonly ILogger<AlbumController> _logger = logger;
    private readonly IAlbumService _albumService = albumService;
    private readonly IArtistService _artistService = artistService;
    private readonly IMemberService _memberService = memberService;
    private readonly IMapper _mapper = mapper;
    private readonly IAlbumHelper _albumHelper = albumHelper;

    [AllowAnonymous]
    [HttpGet("")]
    public async Task<ActionResult<List<SearchResponse>>> SearchAsync([FromQuery] string criteria)
    {
        if (string.IsNullOrEmpty(criteria))
            return Ok(new SearchResponse(null, null, null));

        var albums = _mapper.Map<List<AlbumLookUpResponse>>(await _albumService.SearchByNameAsync(criteria));
        var artists = _mapper.Map<List<ArtistLookUpResponse>>(await _artistService.SearchByNameAsync(criteria));
        var members = _mapper.Map<List<MemberLookUpResponse>>(await _memberService.SearchByNameAsync(criteria));

        return Ok(new SearchResponse(albums, artists, members));
    }
}