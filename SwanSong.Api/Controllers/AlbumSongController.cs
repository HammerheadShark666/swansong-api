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
[Route("api/v{version:apiVersion}/album/songs")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class AlbumSongController : BaseController<AlbumSong>
{ 
    private readonly ILogger<AlbumSongController> _logger;
    private readonly IAlbumSongService _albumSongService; 
    private readonly IMapper _mapper; 

    public AlbumSongController(ILogger<AlbumSongController> logger, IAlbumSongService albumSongService,
                               IValidator<AlbumSong> validator, IMapper mapper) : base(validator)
    {
        _logger = logger;
        _albumSongService = albumSongService; 
        _mapper = mapper; 
    }

    [HttpGet("{albumId}")]
    public async Task<ActionResult<List<AlbumSongResponse>>> GetSearchAlbumSongsAsync(long albumId)
    {
        var albumSongs = await _albumSongService.GetAlbumSongsAsync(albumId);
        return Ok(_mapper.Map<List<AlbumSongResponse>>(albumSongs));            
    }

    [HttpPost("song/add")]
    public async Task<ActionResult<AlbumSongActionResponse>> PostAddAlbumSongAsync([FromBody] AlbumSongAddRequest albumSongAddRequest)
    {
        AlbumSong albumSong = _mapper.Map<AlbumSong>(albumSongAddRequest);

        var validationResult = await Validate(albumSong, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        await _albumSongService.AddAsync(albumSong);

        return Ok(new AlbumSongActionResponse(albumSong.Id, albumSong.SongId));
    }

    [HttpPut("song/update")]
    public async Task<ActionResult<AlbumSongActionResponse>> PutUpdateAlbumSongAsync([FromBody] AlbumSongUpdateRequest albumSongUpdateRequest)
    {
        AlbumSong albumSong = _mapper.Map<AlbumSong>(albumSongUpdateRequest);

        var validationResult = await Validate(albumSong, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _albumSongService.Update(albumSong);

        return Ok(); 
    }

    [HttpDelete("song/{id}")]
    public async Task<ActionResult<AlbumSongActionResponse>> DeleteAlbumSongAsync(long id)
    { 
        _albumSongService.DeleteAsync(await _albumSongService.GetAsync(id));

        return Ok(); 
    }
}