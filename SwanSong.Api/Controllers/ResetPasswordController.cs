using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api/v{version:apiVersion}/forgot-password")]
public class ResetPasswordController : Controller
{
    private readonly ILogger<ResetPasswordController> _logger;
    private readonly IResetPasswordService _resetPasswordService;

    public ResetPasswordController(IResetPasswordService resetPasswordService, ILogger<ResetPasswordController> logger)
    { 
        _resetPasswordService = resetPasswordService;
        _logger = logger;
    }

    [HttpPost("")]
    public async Task<ActionResult> PostForgotPasswordAsync(ForgotPasswordRequest forgotPasswordRequest)
    {
        await _resetPasswordService.ForgotPasswordAsync(forgotPasswordRequest);
        return Ok(new { message = ConstantMessages.PasswordResetEmailInstruction });
    }

    [HttpPost("validate-reset-token")]
    public async Task<ActionResult> PostValidateResetTokenAsync(ValidateResetTokenRequest validateResetTokenRequest)
    {
        await _resetPasswordService.ValidateResetTokenAsync(validateResetTokenRequest);
        return Ok(new { message = ConstantMessages.TokenValid });
    }

    [HttpPost("reset-password")]
    public async Task<ActionResult> PostResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new { message = GetMessages() });
        }

        await _resetPasswordService.ResetPasswordAsync(resetPasswordRequest);
        return Ok();
    }

    private string GetMessages()
    {
        return string.Join("; ", ModelState.Values
                                    .SelectMany(x => x.Errors)
                                    .Select(x => x.ErrorMessage));
    }
}