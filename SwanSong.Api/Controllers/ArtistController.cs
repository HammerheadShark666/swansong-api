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

//[Authorize]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/artists")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class ArtistController(ILogger<AlbumController> logger,
                              IArtistService artistService,
                              IValidator<Artist> validator,
                              IMapper mapper) : BaseController<Artist>(validator)
{
    private readonly ILogger<AlbumController> _logger = logger;
    private readonly IArtistService _artistService = artistService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("lookups")]
    public ActionResult<List<ArtistLookUpResponse>> GetAllArtistsAsync()
    {
        var artists = _artistService.GetAll();
        return Ok(_mapper.Map<List<ArtistLookUpResponse>>(artists));
    }

    [AllowAnonymous]
    [HttpGet("random")]
    public async Task<ActionResult<List<ArtistLookUpResponse>>> GetRandomArtistsAsync()
    {
        return Ok(_mapper.Map<List<ArtistLookUpResponse>>(await _artistService.GetRandomAsync(EnvironmentVariablesHelper.NumberOfRandomRecords)));
    }

    [HttpGet("")]
    public async Task<ActionResult<List<ArtistResponse>>> GetAllArtistsAsync([FromQuery] PaginationFilter filter)
    {
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var artists = await _artistService.GetAllAsync(validFilter);
        var totalRecords = await _artistService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<ArtistResponse>(_mapper.Map<List<ArtistResponse>>(artists), validFilter, totalRecords));
    }

    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<ArtistResponse>>> GetSearchArtistsAsync(string criteria)
    {
        return Ok(_mapper.Map<List<ArtistLookUpResponse>>(await _artistService.SearchByNameAsync(criteria)));
    }

    [HttpGet("search-by-letter/{letter}")]
    public async Task<ActionResult<List<ArtistResponse>>> GetSearchAlbumsByLetterAsync(string letter)
    {
        return Ok(_mapper.Map<List<ArtistLookUpResponse>>(await _artistService.SearchByAlphaNumericAsync(letter)));
    }

    [HttpGet("artist/{id}")]
    public async Task<ActionResult<ArtistResponse>> GetArtistAsync(long id)
    {
        return Ok(_mapper.Map<ArtistResponse>(await _artistService.GetAsync(id)));
    }

    [AllowAnonymous]
    [HttpGet("artist-full-details/{id}")]
    public async Task<ActionResult<ArtistWithAlbumsResponse>> GetArtistWithAlbumsAsync(long id)
    {
        return Ok(_mapper.Map<ArtistWithAlbumsResponse>(await _artistService.GetArtistFullDetailsAsync(id)));
    }

    [HttpPost("artist/add")]
    public async Task<ActionResult<ArtistActionResponse>> PostAddArtistAsync([FromBody] ArtistAddRequest artistAddRequest)
    {
        Artist artist = _mapper.Map<Artist>(artistAddRequest);

        var validationResult = await Validate(artist, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedArtist = await _artistService.AddAsync(artist);

        return Ok(new ArtistActionResponse(savedArtist.Id));
    }

    [HttpPut("artist/update")]
    public async Task<ActionResult<ArtistActionResponse>> PutUpdateArtistAsync([FromBody] ArtistUpdateRequest artistUpdateRequest)
    {
        Artist artist = _mapper.Map<Artist>(artistUpdateRequest);

        var validationResult = await Validate(artist, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _artistService.Update(artist);

        return Ok();
    }


    [HttpDelete("artist/{id}")]
    public async Task<ActionResult<ArtistResponse>> DeleteArtistAsync(long id)
    {
        await _artistService.DeleteAsync(await _artistService.GetAsync(id));
        return Ok();
    }

    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [HttpPost("artist/upload-photo/{id}")]
    public async Task<ActionResult> SavePhotoAsync(long id)
    {
        if (Request.Form.Files.Count > 0)
        {
            var filename = await _artistService.UpdateArtistPhotoAsync(id, Request.Form.Files[0]);
            return Ok(new AlbumPhotoActionResponse(filename));
        }
        else
        {
            return BadRequest(ConstantMessages.NoFileToSave);
        }
    }
}