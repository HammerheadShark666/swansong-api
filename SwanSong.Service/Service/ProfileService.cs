using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class ProfileService : IProfileService
{ 
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<ProfileRequest> _validatorHelper;

    public ProfileService(IMapper mapper,
                          IValidatorHelper<ProfileRequest> validatorHelper, 
                          IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<ProfileResponse> GetAsync(int id)
    {
        return _mapper.Map<ProfileResponse>(await _unitOfWork.Accounts.ByIdAsync(id));
    }

    public async Task UpdateAsync(int id, ProfileRequest profileRequest)
    { 
        profileRequest = profileRequest with { Id = id };

        await _validatorHelper.ValidateAsync(profileRequest, Constants.ValidationEventBeforeSave);
        await UpdateAccountAsync(profileRequest);

        return;
    }

    #endregion

    #region Private Functions
    
    private async Task UpdateAccountAsync(ProfileRequest profileRequest)
    {
        Account account = await GetAccountAsync(profileRequest.Id);
        account = _mapper.Map<ProfileRequest, Account>(profileRequest, account);

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