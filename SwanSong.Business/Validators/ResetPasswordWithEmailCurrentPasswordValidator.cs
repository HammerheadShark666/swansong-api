// Ignore Spelling: Validator

using FluentValidation;
using Microsoft.Extensions.Logging;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class ResetPasswordWithEmailCurrentPasswordValidator : BaseValidator<ResetPasswordWithEmailCurrentPasswordRequest>
{
    private readonly IAccountRepository _accountRepository;
    private ILogger<ResetPasswordWithEmailCurrentPasswordValidator> _logger;

    public ResetPasswordWithEmailCurrentPasswordValidator(IAccountRepository accountRepository, ILogger<ResetPasswordWithEmailCurrentPasswordValidator> logger)
    {
        _accountRepository = accountRepository;
        _logger = logger;

        RuleSet("BeforeSave", () =>
        {
            RuleFor(resetPassword => resetPassword.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Length(8, 150).WithMessage("Email length between 8 and 150.")
                .EmailAddress().WithMessage("Invalid Email.");

            RuleFor(resetPassword => resetPassword.CurrentPassword)
                .NotEmpty().WithMessage("Current Password is required.")
                .Length(8, 50).WithMessage("Current Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.Password)
                .Equal(resetPassword => resetPassword.ConfirmPassword)
                .WithMessage("Password and Confirm Password must be same");

            RuleFor(resetPassword => resetPassword).MustAsync(async (resetPassword, cancellation) =>
            {
                return await ResetDataValid(resetPassword);
            }).WithMessage("The reset information is invalid");
        });
    }

    protected async Task<bool> ResetDataValid(ResetPasswordWithEmailCurrentPasswordRequest resetPasswordRequest)
    {
        var tokenValid = await _accountRepository.ValidResetTokenEmailCurrentPasswordAsync(resetPasswordRequest.Token, resetPasswordRequest.Email, resetPasswordRequest.CurrentPassword);
        if (!tokenValid)
            _logger.LogWarning("Reset values invalid for reset password (Token - {token})", resetPasswordRequest.Token);

        return tokenValid;
    }
}