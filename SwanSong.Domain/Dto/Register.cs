﻿namespace SwanSong.Domain.Dto;

public record RegisterRequest(string FirstName, string LastName, string Email,
                              string Password, string ConfirmPassword);

public record RegisterVerifyEmailRequest(string Token);