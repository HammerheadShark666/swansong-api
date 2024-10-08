using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static SwanSong.Domain.Helper.Enums;

namespace SwanSong.Domain;

[Table("SWSG_Account")]
public class Account
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public bool AcceptTerms { get; set; }
    public Role Role { get; set; }
    public string VerificationToken { get; set; }
    public DateTime? Verified { get; set; }
    public bool IsAuthenticated => Verified.HasValue || PasswordReset.HasValue;
    public string ResetToken { get; set; }
    public DateTime? ResetTokenExpires { get; set; }
    public DateTime? PasswordReset { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public List<RefreshToken> RefreshTokens { get; set; }

    public Account()
    {
        RefreshTokens = new List<RefreshToken> { };
    }
}