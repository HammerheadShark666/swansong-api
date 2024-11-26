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
                             IValidator<Album> validator,
                             IMapper mapper,
                             IAlbumHelper albumHelper) : BaseController<Album>(validator)
{
    private readonly ILogger<AlbumController> _logger = logger;
    private readonly IAlbumService _albumService = albumService;
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

        _albumService.Update(album);

        return Ok();
    }

    [HttpDelete("album/{id}")]
    public async Task<ActionResult> DeleteAlbumAsync(long id)
    {
        await _albumService.DeleteAsync(await _albumService.GetAsync(id));
        return Ok();
    }

    [HttpPost("album/upload-photo/{id}")]
    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> PostSaveAlbumPhotoAsync(long id)
    {
        if (Request.Form.Files.Count > 0)
        {
            var filename = await _albumService.UpdateAlbumPhotoAsync(id, Request.Form.Files[0]);
            return Ok(new AlbumPhotoActionResponse(filename));
        }
        else
        {
            return BadRequest(ConstantMessages.NoFileToSave);
        }
    }
}