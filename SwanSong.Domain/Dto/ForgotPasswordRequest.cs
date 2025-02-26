using System.ComponentModel.DataAnnotations;

namespace SwanSong.Domain.Dto;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string FrontEndUrl { get; set; }
}