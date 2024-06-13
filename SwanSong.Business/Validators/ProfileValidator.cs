using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class ProfileValidator : BaseValidator<ProfileRequest>
{
    private readonly IAccountRepository _accountRepository;

    public ProfileValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(profile => profile.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Length(8, 150).WithMessage("Email length between 8 and 150.")
                .EmailAddress().WithMessage("Invalid Email.");

            RuleFor(profile => profile.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .Length(2, 50).WithMessage("First Name length between 2 and 50.");

            RuleFor(profile => profile.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .Length(2, 50).WithMessage("Last Name length between 2 and 50.");

            RuleFor(register => register).MustAsync(async (register, cancellation) => {
                return await EmailExists(register);
            }).WithMessage("Account with email already exists");
        });
    }

    protected async Task<bool> EmailExists(ProfileRequest profileRequest)
    {
        return !(await _accountRepository.AccountExistsAsync(profileRequest.Email, profileRequest.Id));
    }
}
