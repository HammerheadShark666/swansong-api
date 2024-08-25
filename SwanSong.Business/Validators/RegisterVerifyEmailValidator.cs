using FluentValidation;
using Microsoft.Extensions.Logging;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class RegisterVerifyEmailValidator : BaseValidator<RegisterVerifyEmailRequest>
{
    private readonly IAccountRepository _accountRepository;
    private ILogger<RegisterVerifyEmailValidator> _logger;

    public RegisterVerifyEmailValidator(IAccountRepository accountRepository, ILogger<RegisterVerifyEmailValidator> logger)
    {
        _accountRepository = accountRepository;
        _logger = logger;

        RuleSet("BeforeSave", () =>
        {

            RuleFor(registerVerifyEmail => registerVerifyEmail.Token)
                .NotEmpty().WithMessage("Token is required.");

            RuleFor(registerVerifyEmail => registerVerifyEmail).MustAsync(async (registerVerifyEmail, cancellation) =>
            {
                return await AccountWithTokenExists(registerVerifyEmail);
            }).WithMessage("Token is invalid");
        });
    }

    protected async Task<bool> AccountWithTokenExists(RegisterVerifyEmailRequest registerVerifyEmailRequest)
    {
        var accountWithTokenExists = await _accountRepository.GetByVerificationTokenAsync(registerVerifyEmailRequest.Token) != null;
        if (!accountWithTokenExists)
            _logger.LogWarning("Account with register token not found (Token - {token})", registerVerifyEmailRequest.Token);

        return accountWithTokenExists;
    }
}