using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api/v{version:apiVersion}/register")]
public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;
    private readonly IRegisterService _registerService;
    private readonly IRegisterVerifyEmailService _registerVerifyEmailService;

    public RegisterController(IRegisterService registerService, IRegisterVerifyEmailService registerVerifyEmailService, ILogger<RegisterController> logger)
    {
        _registerService = registerService;
        _registerVerifyEmailService = registerVerifyEmailService;
        _logger = logger;
    }

    [HttpPost("")]
    public async Task<ActionResult> PostRegisterAsync(RegisterRequest registerRequest)
    {
        await _registerService.RegisterAsync(registerRequest);
        return Ok();        
    }

    [HttpPost("verify-email")]
    public async Task<ActionResult> PostVerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        await _registerVerifyEmailService.VerifyEmailAsync(registerVerifyEmailRequest);
        return Ok();
    }
}