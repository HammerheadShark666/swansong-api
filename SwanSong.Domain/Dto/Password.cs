using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record ResetPasswordRequest(string Token, string Password, string ConfirmPassword);
public record ResetPasswordActionResponse(List<Message> Messages, bool IsValid);
public record ResetPasswordWithEmailCurrentPasswordRequest(string Email, string CurrentPassword, string Token, string Password, string ConfirmPassword);
public record ResetPasswordWithEmailCurrentPasswordActionResponse(List<Message> Messages, bool IsValid);

