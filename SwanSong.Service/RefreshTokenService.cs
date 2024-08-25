using AutoMapper;
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

namespace SwanSong.Service;

public class RefreshTokenService(IMapper mapper,
                                 IValidatorHelper<LoginRequest> validatorHelper,
                                 IUnitOfWork unitOfWork) : IRefreshTokenService
{
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<LoginRequest> _validatorHelper = validatorHelper;

    public void RemoveExpiredRefreshTokens(int accountId)
    {
        _unitOfWork.RefreshTokens.RemoveExpired(EnvironmentVariablesHelper.JwtSettingsRefreshTokenTtl, accountId);
        _unitOfWork.Complete();
    }

    public async Task AddRefreshToken(RefreshToken refreshToken)
    {
        await _unitOfWork.RefreshTokens.AddAsync(refreshToken);
        await _unitOfWork.CompleteAsync();
    }

    public RefreshToken GenerateRefreshToken(string ipAddress, Account account)
    {
        var refreshTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenExpiryDays);
        var refreshToken = AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
        refreshToken.Account = account;

        return refreshToken;
    }

    public async Task<RefreshToken> GetRefreshTokenAsync(string token)
    {
        var refreshToken = await _unitOfWork.RefreshTokens.ByTokenAsync(token);
        if (refreshToken == null || !refreshToken.IsActive)
        {
            throw new AppException(ConstantMessages.InvalidToken);
        }

        return refreshToken;
    }
}