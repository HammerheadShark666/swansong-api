using FluentValidation;
using Microsoft.Extensions.Logging;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Business.Validator;

public class ProfilePasswordChangeValidator : BaseValidator<ProfilePasswordChangeRequest>
{
    private readonly IAccountRepository _accountRepository;
    private ILogger<ProfilePasswordChangeValidator> _logger;

    public ProfilePasswordChangeValidator(IAccountRepository accountRepository, ILogger<ProfilePasswordChangeValidator> logger)
    {
        _accountRepository = accountRepository;
        _logger = logger;

        RuleSet("BeforeSave", () => {

            RuleFor(profilePasswordChange => profilePasswordChange.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");

            RuleFor(profilePasswordChange => profilePasswordChange.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Length(8, 50).WithMessage("Confirm Password length between 8 and 50.");

            RuleFor(profilePasswordChange => profilePasswordChange.Password)
                .Equal(profilePasswordChange => profilePasswordChange.ConfirmPassword)
                .WithMessage("Password and Confirm Password must be same.");

            RuleFor(login => login).MustAsync(async (profilePasswordChange, cancellation) => {
                return await ValidAccountDetails(profilePasswordChange);
            }).WithMessage("Current password is invalid.");
        });
    }

    protected async Task<bool> ValidAccountDetails(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        var account = await _accountRepository.GetAsync(profilePasswordChangeRequest.Email);
        if (account == null || !account.IsAuthenticated || !BC.Verify(profilePasswordChangeRequest.CurrentPassword, account.PasswordHash))
        {
            _logger.LogWarning("Invalid authentication (Username - {username})", profilePasswordChangeRequest.Email);
            return false;
        }           

        return true;
    }
}
