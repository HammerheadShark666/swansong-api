using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class AuthenticateService(IMapper mapper,
                                 IValidatorHelper<LoginRequest> validatorHelper,
                                 IUnitOfWork unitOfWork,
                                 IRefreshTokenService refreshTokenService) : IAuthenticateService
{
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<LoginRequest> _validatorHelper = validatorHelper;
    public readonly IRefreshTokenService _refreshTokenService = refreshTokenService;

    #region Public Functions

    public async Task<Authenticated> AuthenticateAsync(LoginRequest loginRequest, string ipAddress)
    {
        var account = await GetAccountAsync(loginRequest.Email);
        var refreshToken = _refreshTokenService.GenerateRefreshToken(ipAddress, account);

        _refreshTokenService.RemoveExpiredRefreshTokens(account.Id);
        await _refreshTokenService.AddRefreshToken(refreshToken);

        var jwtToken = AuthenticationHelper.GenerateJwtToken(account,
                                                             EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes,
                                                             EnvironmentVariablesHelper.JwtSettingsSercret);

        return new Authenticated(jwtToken, refreshToken.Token, new Domain.Dto.Profile(account.FirstName, account.LastName, account.Email));
    }

    public async Task<JwtRefreshToken> RefreshTokenAsync(string token, string ipAddress)
    {
        var refreshToken = await _refreshTokenService.GetRefreshTokenAsync(token);
        var newRefreshToken = _refreshTokenService.GenerateRefreshToken(ipAddress, refreshToken.Account);

        _refreshTokenService.RemoveExpiredRefreshTokens(refreshToken.Account.Id);
        await _refreshTokenService.AddRefreshToken(newRefreshToken);

        var jwtToken = AuthenticationHelper.GenerateJwtToken(refreshToken.Account,
                                                             EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes,
                                                             EnvironmentVariablesHelper.JwtSettingsSercret);

        return new JwtRefreshToken(refreshToken.Account.IsAuthenticated, jwtToken, newRefreshToken.Token,
                                                 new SwanSong.Domain.Dto.Profile(refreshToken.Account.FirstName, refreshToken.Account.LastName, refreshToken.Account.Email),
                                                 refreshToken.Account.Role.ToString());
    }

    #endregion

    #region Private Functions

    private async Task<Account> GetAccountAsync(string email)
    {
        return await _unitOfWork.Accounts.GetAsync(email) ?? throw new AppException(ConstantMessages.InvalidToken);
    }

    #endregion
}