using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Authorize]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/songs")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class SongController(ILogger<AlbumSongController> logger,
                            ISongService songService) : Controller
{
    private readonly ILogger<AlbumSongController> _logger = logger;
    private readonly ISongService _songService = songService;

    [HttpDelete("song/{id}")]
    public async Task<ActionResult<AlbumSongActionResponse>> DeleteSongAsync(long id)
    {
        _songService.Delete(await _songService.GetSongAsync(id));
        return Ok();
    }
}