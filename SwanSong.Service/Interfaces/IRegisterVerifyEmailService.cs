using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRegisterVerifyEmailService
{
    Task VerifyEmailAsync(RegisterVerifyEmailRequest registerVerifyEmailRequest);
}