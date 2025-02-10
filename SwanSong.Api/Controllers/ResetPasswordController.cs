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
public class ResetPasswordController(IResetPasswordService resetPasswordService,
                                     ILogger<ResetPasswordController> logger) : Controller
{
    private readonly ILogger<ResetPasswordController> _logger = logger;
    private readonly IResetPasswordService _resetPasswordService = resetPasswordService;

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
        return Ok(new { message = "Password has been reset." });
    }

    [HttpPost("reset-password-with-email-current-password")]
    public async Task<ActionResult> PostResetPasswordWithEmailCurrentPasswordAsync(ResetPasswordWithEmailCurrentPasswordRequest resetPasswordWithEmailCurrentPasswordRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new { message = GetMessages() });
        }

        await _resetPasswordService.ResetPasswordWithEmailCurrentPasswordAsync(resetPasswordWithEmailCurrentPasswordRequest);
        return Ok(new { message = "Password has been reset." });
    }

    private string GetMessages()
    {
        return string.Join("; ", ModelState.Values
                                    .SelectMany(x => x.Errors)
                                    .Select(x => x.ErrorMessage));
    }
}