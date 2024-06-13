using FluentValidation;
using Microsoft.Extensions.Logging;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class ResetPasswordValidator : BaseValidator<ResetPasswordRequest>
{
    private readonly IAccountRepository _accountRepository; 
    private ILogger<ResetPasswordValidator> _logger;

    public ResetPasswordValidator(IAccountRepository accountRepository, ILogger<ResetPasswordValidator> logger)
    {
        _accountRepository = accountRepository;
        _logger = logger;

        RuleSet("BeforeSave", () => {

            RuleFor(resetPassword => resetPassword.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

            RuleFor(resetPassword => resetPassword.Password)
                .Equal(resetPassword => resetPassword.ConfirmPassword)
                .WithMessage("Password and Confirm Password must be same");

            RuleFor(resetPassword => resetPassword).MustAsync(async (resetPassword, cancellation) => {
                return await TokenValid(resetPassword);
            }).WithMessage("Token is invalid");
        });
    }
  
    protected async Task<bool> TokenValid(ResetPasswordRequest resetPasswordRequest)
    {
        var tokenValid = await _accountRepository.ValidResetTokenAsync(resetPasswordRequest.Token);
        if (!tokenValid)
            _logger.LogWarning("Token invalid for reset password (Token - {token})", resetPasswordRequest.Token);

        return tokenValid;
    }        
}