using FluentValidation;
using Microsoft.Extensions.Logging;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class RegisterValidator : BaseValidator<RegisterRequest>
{
    private readonly IAccountRepository _accountRepository;

    private ILogger<RegisterValidator> _logger;

    public RegisterValidator(IAccountRepository accountRepository, ILogger<RegisterValidator> logger)
    {
        _accountRepository = accountRepository;
        _logger = logger;

        RuleSet("BeforeSave", () => {

            RuleFor(register => register.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Length(8, 150).WithMessage("Email length between 8 and 150.")
                .EmailAddress().WithMessage("Invalid Email.");

            RuleFor(register => register.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .Length(2, 50).WithMessage("First Name length between 2 and 50.");

            RuleFor(register => register.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .Length(2, 50).WithMessage("Last Name length between 2 and 50.");

            RuleFor(register => register.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(register => register.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

            RuleFor(register => register.Password)
                .Equal(register => register.ConfirmPassword)
                .WithMessage("Password and Confirm Password must be same");

            RuleFor(register => register).MustAsync(async (register, cancellation) => {
                return await EmailExists(register);
            }).WithMessage("Account with email already exists");
        });
    }

    protected async Task<bool> EmailExists(RegisterRequest register)
    {
        var emailExists = await _accountRepository.AccountExistsAsync(register.Email);
        if(emailExists)
            _logger.LogWarning("Email exists (Email = {email}", register.Email);

        return !emailExists;                
    }                    
}