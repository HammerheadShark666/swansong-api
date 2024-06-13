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
public class AlbumController : BaseController<Album>
{
    private readonly ILogger<AlbumController> _logger;
    private readonly IAlbumService _albumService;
    private readonly IMapper _mapper;
    private readonly IAlbumHelper _albumHelper;

    public AlbumController(ILogger<AlbumController> logger, IAlbumService albumService, 
                           IValidator<Album> validator, IMapper mapper, IAlbumHelper albumHelper) : base(validator)
    {
        _logger = logger;
        _mapper = mapper;
        _albumService = albumService;
        _albumHelper = albumHelper;
    }
     
    [HttpGet("")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetAllAsync([FromQuery] PaginationFilter filter)
    {
        var paginationFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var albums = await _albumService.GetAllAsync(paginationFilter);
        var totalRecords = await _albumService.CountAsync(); 

        return Ok(PagingHelper.CreatePagedReponse<AlbumLookUpResponse>(_mapper.Map<List<AlbumLookUpResponse>>(albums), paginationFilter, totalRecords));
    }

    [HttpGet("random")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetRandomAsync()
    {
        var albums = await _albumService.GetRandomAsync(10);  
        return Ok(_albumHelper.GetAlbumLookUps(albums));
    } 

    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> SearchAsync(string criteria)
    {
        var albums = await _albumService.SearchByNameAsync(criteria); 
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(albums));
    }

    [HttpGet("search-by-letter/{letter}")] 
    public async Task<ActionResult<List<AlbumLookUpResponse>>> SearchByLetterAsync(string letter)
    {
        var albums = await _albumService.SearchByLetterAsync(letter);
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(albums));
    }

    [HttpGet("album/{id}")]
    public async Task<ActionResult<AlbumResponse>> GetAlbumAsync(long id)
    {         
        return Ok(_mapper.Map<AlbumResponse>(await _albumService.GetAsync(id)));
    }

    [HttpGet("artist/{id}")]
    public async Task<ActionResult<List<AlbumLookUpResponse>>> GetAlbumsForArtistAsync(long id)
    {
        var albums = await _albumService.GetAlbumsForArtistAsync(id);
        return Ok(_mapper.Map<List<AlbumLookUpResponse>>(albums));
    }

    [HttpPost("album/add")]
    public async Task<ActionResult<AlbumActionResponse>> AddAsync([FromBody] AlbumAddRequest albumAddRequest)
    {
        Album album = _mapper.Map<Album>(albumAddRequest);
 
        var validationResult = await Validate(album, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedAlbum = await _albumService.AddAsync(album);

        return Ok(new AlbumActionResponse(album.Id));        
    }

    [HttpPut("album/update")]
    public async Task<ActionResult> UpdateAsync([FromBody] AlbumUpdateRequest albumUpdateRequest)
    {  
        Album album = _mapper.Map<Album>(albumUpdateRequest);
         
        var validationResult = await Validate(album, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _albumService.Update(album);

        return Ok();
    } 

    [HttpDelete("album/{id}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        await _albumService.DeleteAsync(await _albumService.GetAsync(id));
        return Ok();
    } 
      
    [HttpPost("album/upload-photo/{id}")]
    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SaveAlbumPhotoAsync(long id)
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