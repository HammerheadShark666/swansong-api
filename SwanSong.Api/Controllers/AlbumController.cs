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
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Filter;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/albums")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Consumes(MediaTypeNames.Application.Json)]
[Produces(MediaTypeNames.Application.Json)]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
public class AlbumController(ILogger<AlbumController> logger,
                             IAlbumService albumService,
                             IArtistService artistService,
                             IRecordLabelService recordLabelService,
                             IStudioService studioService,
                             IValidator<Album> validator,
                             IMapper mapper,
                             IAlbumHelper albumHelper) : BaseController<Album>(validator)
{
    private readonly ILogger<AlbumController> _logger = logger;
    private readonly IAlbumService _albumService = albumService;
    private readonly IArtistService _artistService = artistService;
    private readonly IRecordLabelService _recordLabelService = recordLabelService;
    private readonly IStudioService _studioService = studioService;
    private readonly IMapper _mapper = mapper;
    private readonly IAlbumHelper _albumHelper = albumHelper;

    [HttpGet("")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetAllAlbumsAsync([FromQuery] PaginationFilter filter)
    {
        var paginationFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var albums = await _albumService.GetAllAsync(paginationFilter);
        var totalRecords = await _albumService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<AlbumLookUpResponse>(_mapper.Map<List<AlbumLookUpResponse>>(albums), paginationFilter, totalRecords));
    }

    [AllowAnonymous]
    [HttpGet("random")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetRandomAlbumsAsync()
    {
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(await _albumService.GetRandomAsync(EnvironmentVariablesHelper.NumberOfRandomRecords)));
    }


    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> SearchAlbumsAsync(string criteria)
    {
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(await _albumService.SearchByNameAsync(criteria)));
    }

    [HttpGet("search-by-letter/{letter}")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> SearchAlbumsByLetterAsync(string letter)
    {
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(await _albumService.SearchByLetterAsync(letter)));
    }

    [AllowAnonymous]
    [HttpGet("album/{id}")]
    public async Task<ActionResult<AlbumResponse>> GetAlbumAsync(long id)
    {
        return Ok(_mapper.Map<AlbumResponse>(await _albumService.GetAsync(id)));
    }

    [HttpGet("artist/{id}")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetAlbumsForArtistAsync(long id)
    {
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(await _albumService.GetAlbumsForArtistAsync(id)));
    }

    [HttpPost("album/add")]
    public async Task<ActionResult<AlbumActionResponse>> PostAddAlbumAsync([FromBody] AlbumAddRequest albumAddRequest)
    {
        Album album = _mapper.Map<Album>(albumAddRequest);

        var validationResult = await Validate(album, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedAlbum = await _albumService.AddAsync(album);

        return Ok(new AlbumActionResponse(savedAlbum.Id));
    }

    [HttpPut("album/update")]
    public async Task<ActionResult> PutUpdateAlbumAsync([FromBody] AlbumUpdateRequest albumUpdateRequest)
    {
        Album album = _mapper.Map<Album>(albumUpdateRequest);

        var validationResult = await Validate(album, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        await _albumService.UpdateAsync(album);

        return Ok(new AlbumActionResponse(album.Id));
    }

    [HttpPut("album/description/update")]
    public async Task<ActionResult> PutUpdateAlbumDescriptionAsync([FromBody] AlbumDescriptionUpdateRequest albumDescriptionUpdateRequest)
    {
        Album album = _mapper.Map<Album>(albumDescriptionUpdateRequest);

        var validationResult = await Validate(album, Constants.ValidationEventBeforeSaveDescription);
        if (validationResult != null)
            return BadRequest(validationResult);

        await _albumService.UpdateDescriptionAsync(albumDescriptionUpdateRequest.Id, albumDescriptionUpdateRequest.Description);

        return Ok(new AlbumActionResponse(album.Id));
    }

    [HttpDelete("album/{id}")]
    public async Task<ActionResult> DeleteAlbumAsync(long id)
    {
        var album = await _albumService.GetAsync(id);
        if (album == null)
            throw new AlbumNotFoundException("Album not found (" + id + ")");

        await _albumService.DeleteAsync(album);
        return Ok(new AlbumActionResponse(id));
    }

    [HttpPost("album/upload-photo/{id}")]
    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> PostSaveAlbumPhotoAsync(long id)
    {
        if (Request.Form.Files.Count > 0)
        {
            var file = Request.Form.Files[0];

            if (file.Length >= Constants.MaxFileSize)
                return BadRequest(new MessageResponse(new List<Message>() { new(ConstantMessages.FileTooBig, "error") }));

            var filename = await _albumService.UpdateAlbumPhotoAsync(id, file);
            return Ok(new AlbumPhotoActionResponse(filename));
        }
        else
        {
            return BadRequest(ConstantMessages.NoFileToSave);
        }
    }

    [HttpGet("lookups")]
    public async Task<ActionResult<AlbumLookUpsResponse>> GetLookupsForAlbumAsync()
    {
        List<ArtistLookUpResponse> artists = _mapper.Map<List<ArtistLookUpResponse>>(_artistService.GetAll());
        List<RecordLabelResponse> recordLabels = _mapper.Map<List<RecordLabelResponse>>(await _recordLabelService.GetAllAsync());
        List<StudioResponse> studios = _mapper.Map<List<StudioResponse>>(await _studioService.GetAllAsync());

        return Ok(new AlbumLookUpsResponse(artists, recordLabels, studios));
    }
}