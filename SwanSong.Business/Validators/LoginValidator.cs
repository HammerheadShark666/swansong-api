using FluentValidation;
using Microsoft.Extensions.Logging;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Business.Validator;

public class LoginValidator : BaseValidator<LoginRequest>
{
    private readonly IAccountRepository _accountRepository;

    private ILogger<LoginValidator> _logger;

    public LoginValidator(IAccountRepository accountRepository, ILogger<LoginValidator> logger)
    {
        _accountRepository = accountRepository;
        _logger = logger;

        RuleSet("BeforeSave", () =>
        {

            RuleFor(login => login.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Length(8, 150).WithMessage("Email length between 8 and 150.")
                .EmailAddress().WithMessage("Invalid Email.");

            RuleFor(login => login.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(login => login).MustAsync(async (login, cancellation) =>
            {
                return await ValidLoginDetails(login);
            }).WithMessage("Invalid login");
        });
    }

    protected async Task<bool> ValidLoginDetails(LoginRequest loginRequest)
    {
        var account = await _accountRepository.GetAsync(loginRequest.Email);
        if (account == null || !account.IsAuthenticated || !BC.Verify(loginRequest.Password, account.PasswordHash))
        {
            _logger.LogWarning("Invalid Login (Username - {username})", loginRequest.Email);
            return false;
        }

        return true;
    }
}