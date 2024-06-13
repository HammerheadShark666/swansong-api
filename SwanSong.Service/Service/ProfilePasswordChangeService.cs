using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service;

public class ProfilePasswordChangeService : IProfilePasswordChangeService
{
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<ProfilePasswordChangeRequest> _validatorHelper;

    public ProfilePasswordChangeService(IMapper mapper,
                                        IValidatorHelper<ProfilePasswordChangeRequest> validatorHelper, 
                                        IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task UpdatePasswordAsync(ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        ProfilePasswordChangeRequest profilePasswordChange = _mapper.Map<ProfilePasswordChangeRequest>(profilePasswordChangeRequest);

        await _validatorHelper.ValidateAsync(profilePasswordChangeRequest, Constants.ValidationEventBeforeSave);
        await UpdatePasswordAsync(profilePasswordChange.Id, profilePasswordChangeRequest);

        return;
    }

    #endregion

    #region Private Functions

    private async Task<Account> UpdatePasswordAsync(int id, ProfilePasswordChangeRequest profilePasswordChangeRequest)
    {
        Account account = await GetAccountAsync(id);

        account = _mapper.Map<ProfilePasswordChangeRequest, Account>(profilePasswordChangeRequest, account);
        account.PasswordHash = BC.HashPassword(profilePasswordChangeRequest.Password);

        await UpdateAccountAsync(account);

        return account;
    }

    private async Task UpdateAccountAsync(Account account)
    {
        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.CompleteAsync();
    }

    private async Task<Account> GetAccountAsync(int id)
    {
        var account = await _unitOfWork.Accounts.ByIdAsync(id);
        if (account == null)
        {
            throw new KeyNotFoundException(ConstantMessages.ProfileNotFound);
        }

        return account;
    }

    #endregion

}