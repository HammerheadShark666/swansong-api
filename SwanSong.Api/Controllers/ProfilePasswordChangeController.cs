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
public class ProfilePasswordChangeController(IProfilePasswordChangeService profilePasswordChangeService,
                                             IHttpContextAccessor httpContextAccessor,
                                             ILogger<ProfilePasswordChangeController> logger) : Controller
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IProfilePasswordChangeService _profilePasswordChangeService = profilePasswordChangeService;
    private readonly ILogger<ProfilePasswordChangeController> _logger = logger;

    [Authorize]
    [HttpPut("")]
    public async Task<ActionResult<ProfilePasswordChangeActionResponse>> PutUpdatePasswordAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        profilePasswordChangeRequest = profilePasswordChangeRequest with { Id = LoggedInAccount().Id, Email = LoggedInAccount().Email };
        await _profilePasswordChangeService.UpdatePasswordAsync(profilePasswordChangeRequest);
        return Ok(new { message = "Password changed." });
    }

    private Account LoggedInAccount()
    {
        var context = _httpContextAccessor.HttpContext;
        return (Account)context.Items["Account"];
    }
}