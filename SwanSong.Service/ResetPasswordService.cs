﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service;

public class ResetPasswordService(IMapper mapper,
                                  IValidatorHelper<ResetPasswordRequest> validatorHelper,
                                  IValidatorHelper<ResetPasswordWithEmailCurrentPasswordRequest> validatorHelperExtraData,
                                  IUnitOfWork unitOfWork,
                                  ILogger<ResetPasswordService> logger) : IResetPasswordService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly IValidatorHelper<ResetPasswordRequest> _validatorHelper = validatorHelper;
    private readonly IValidatorHelper<ResetPasswordWithEmailCurrentPasswordRequest> _validatorHelperExtraData = validatorHelperExtraData;
    private readonly ILogger<ResetPasswordService> _logger = logger;

    #region Public Functions

    public async Task ForgotPasswordAsync(ForgotPasswordRequest forgotPasswordRequest)
    {
        var account = await _unitOfWork.Accounts.GetAsync(forgotPasswordRequest.Email);
        if (account == null)
        {
            _logger.LogWarning("Account not found (Email - {email}", forgotPasswordRequest.Email);
            throw new AppException("Account not found");
        }

        await UpdateResetTokenAsync(GetResetToken(account));

        SendPasswordResetEmail(account.Email, account.ResetToken, forgotPasswordRequest.FrontEndUrl);
    }

    public async Task ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
    {
        await BeforeResetPasswordAsync(resetPasswordRequest); ;
        await UpdateAccountAsync(resetPasswordRequest.Token, resetPasswordRequest.Password);

        return;
    }

    public async Task ResetPasswordWithEmailCurrentPasswordAsync(ResetPasswordWithEmailCurrentPasswordRequest resetPasswordRequest)
    {
        await BeforeResetPasswordWithEmailCurrentPasswordAsync(resetPasswordRequest); ;
        await UpdateAccountAsync(resetPasswordRequest.Token, resetPasswordRequest.Password);

        return;
    }

    public async Task ValidateResetTokenAsync(ValidateResetTokenRequest validateResetTokenRequest)
    {
        if (!await _unitOfWork.Accounts.ValidResetTokenAsync(validateResetTokenRequest.Token))
        {
            throw new AppException("Invalid token");
        }
    }

    #endregion

    #region Private Functions  

    private async Task BeforeResetPasswordWithEmailCurrentPasswordAsync(ResetPasswordWithEmailCurrentPasswordRequest resetPasswordRequest)
    {
        await _validatorHelperExtraData.ValidateAsync(resetPasswordRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task BeforeResetPasswordAsync(ResetPasswordRequest resetPasswordRequest)
    {
        await _validatorHelper.ValidateAsync(resetPasswordRequest, Constants.ValidationEventBeforeSave);
    }

    private async Task UpdateResetTokenAsync(Account account)
    {
        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.CompleteAsync();
    }

    private async Task UpdateAccountAsync(string token, string password)
    {
        _unitOfWork.Accounts.Update(await UpdateAccountRecordAsync(token, password));
        await _unitOfWork.CompleteAsync();
    }

    private async Task<Account> UpdateAccountRecordAsync(string resetToken, string password)
    {
        var account = await _unitOfWork.Accounts.GetByResetTokenAsync(resetToken);

        if (account == null)
        {
            throw new AppException("Account not found");
        }

        account.PasswordHash = BC.HashPassword(password);
        account.PasswordReset = DateTime.Now;
        account.ResetToken = null;
        account.ResetTokenExpires = null;

        return account;
    }

    private static Account GetResetToken(Account account)
    {
        account.ResetToken = AuthenticationHelper.CreateRandomToken();
        account.ResetTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsPasswordTokenExpiryDays);

        return account;
    }

    private static void SendPasswordResetEmail(string toEmail, string resetToken, string frontEndUrl)
    {
        string message = !string.IsNullOrEmpty(frontEndUrl)
                             ? EmailMessages.PasswordResetEmail(frontEndUrl, resetToken)
                             : EmailMessages.PasswordResetNoResetUrlEmail(resetToken);

        SmtpHelper.SendEmail(toEmail, ConstantMessages.PasswordResetEmailInstruction, message);
    }

    #endregion
}