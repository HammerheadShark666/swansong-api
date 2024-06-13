using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api/v{version:apiVersion}/profile/password-change")]
public class ProfilePasswordChangeController : Controller
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IProfilePasswordChangeService _profilePasswordChangeService;
    private readonly ILogger<ProfilePasswordChangeController> _logger; 

    public ProfilePasswordChangeController(IProfilePasswordChangeService profilePasswordChangeService, IHttpContextAccessor httpContextAccessor, ILogger<ProfilePasswordChangeController> logger)
    {
        _httpContextAccessor = httpContextAccessor;
        _profilePasswordChangeService = profilePasswordChangeService;
        _logger = logger;
    }
     

    [Authorize]
    [HttpPut("")]
    public async Task<ActionResult<ProfilePasswordChangeActionResponse>> UpdatePasswordAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        profilePasswordChangeRequest = profilePasswordChangeRequest with { Id = LoggedInAccount().Id, Email = LoggedInAccount().Email };
        await _profilePasswordChangeService.UpdatePasswordAsync(profilePasswordChangeRequest);
        return Ok();
    }

    private Account LoggedInAccount()
    {
        var context = _httpContextAccessor.HttpContext;
        return (Account)context.Items["Account"];
    }
}