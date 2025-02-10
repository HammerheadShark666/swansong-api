using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IResetPasswordService
{
    Task ForgotPasswordAsync(ForgotPasswordRequest model);
    Task ValidateResetTokenAsync(ValidateResetTokenRequest model);
    Task ResetPasswordAsync(ResetPasswordRequest resetPasswordRequest);
    Task ResetPasswordWithEmailCurrentPasswordAsync(ResetPasswordWithEmailCurrentPasswordRequest resetPasswordRequest);
}