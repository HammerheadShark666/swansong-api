using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IAuthenticateService
{
    Task<Authenticated> AuthenticateAsync(LoginRequest loginRequest, string ipAddress);
    Task<JwtRefreshToken> RefreshTokenAsync(string token, string ipAddress);
}