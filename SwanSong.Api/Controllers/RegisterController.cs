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
public class RegisterController(IRegisterService registerService,
                                IRegisterVerifyEmailService registerVerifyEmailService,
                                ILogger<RegisterController> logger) : Controller
{
    private readonly ILogger<RegisterController> _logger = logger;
    private readonly IRegisterService _registerService = registerService;
    private readonly IRegisterVerifyEmailService _registerVerifyEmailService = registerVerifyEmailService;

    [HttpPost("")]
    public async Task<ActionResult> PostRegisterAsync([FromBody] RegisterRequest registerRequest)
    {
        await _registerService.RegisterAsync(registerRequest);
        return Ok(new { message = "Registration successful" });
    }

    [HttpPost("verify-email")]
    public async Task<ActionResult> PostVerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        await _registerVerifyEmailService.VerifyEmailAsync(registerVerifyEmailRequest);
        return Ok(new { message = "Registration verified" });
    }
}