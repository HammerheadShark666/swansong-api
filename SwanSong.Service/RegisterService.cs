using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;
using static SwanSong.Domain.Helper.Enums;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service;

public class RegisterService(IMapper mapper,
                             IValidatorHelper<RegisterRequest> validatorHelper,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork) : IRegisterService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<RegisterRequest> _validatorHelper = validatorHelper;

    #region Private Functions

    public async Task RegisterAsync(RegisterRequest registerRequest)
    {
        await BeforeRegisterAsync(registerRequest);
        Account account = await SaveAccountAsync(await CreateAccountAsync(registerRequest));

        SendVerificationEmail(account.Email, account.VerificationToken);

        return;
    }

    #endregion

    #region Private Functions

    private async Task BeforeRegisterAsync(RegisterRequest registerRequest)
    {
        await _validatorHelper.ValidateAsync(registerRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task<Account> CreateAccountAsync(RegisterRequest registerRequest)
    {
        var account = _mapper.Map<Account>(registerRequest);

        var isFirstAccount = await _unitOfWork.Accounts.AnyAccountExistAsync();
        account.Role = isFirstAccount ? Role.Admin : Role.User;
        account.Created = DateTime.Now;
        account.VerificationToken = AuthenticationHelper.CreateRandomToken();
        account.PasswordHash = BC.HashPassword(registerRequest.Password);

        return account;
    }

    private static void SendVerificationEmail(string toEmail, string verificationToken)
    {
        string message = !string.IsNullOrEmpty(EnvironmentVariablesHelper.ProductionFrontEndBaseUrl)
                              ? EmailMessages.VerifyEmailAddressEmail(EnvironmentVariablesHelper.ProductionFrontEndBaseUrl, verificationToken)
                              : EmailMessages.VerifyEmailAddressNoVerifyUrlEmail(verificationToken);

        SmtpHelper.SendEmail(toEmail, ConstantMessages.RegistrationVerifyEmailSubject, message);
    }

    public async Task<Account> SaveAccountAsync(Account account)
    {
        _unitOfWork.Accounts.Add(account);
        await _unitOfWork.CompleteAsync();

        return account;
    }

    #endregion

}