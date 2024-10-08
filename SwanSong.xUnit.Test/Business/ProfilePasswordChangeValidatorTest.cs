﻿using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;
using Moq;
using SwanSong.Business.Validator;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.xUnit.Test.Helpers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SwanSong.xUnit.Test.Business;

public class ProfilePasswordChangeValidatorTest
{
    private Mock<IAccountRepository> accountRepositoryMock;
    private Mock<ILogger<ProfilePasswordChangeValidator>> loggerMock;
    private IValidator<ProfilePasswordChangeRequest> validator;

    public ProfilePasswordChangeValidatorTest()
    {
        accountRepositoryMock = new Mock<IAccountRepository>();
        loggerMock = new Mock<ILogger<ProfilePasswordChangeValidator>>();
        validator = new ProfilePasswordChangeValidator(accountRepositoryMock.Object, loggerMock.Object);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_change_return_true()
    {
        Account account = new()
        {
            Verified = new DateTime(),
            PasswordHash = "$2a$11$cHlJvvDHx8AZhGkRBJZCGeUYSbllmnU8y5B9JlB/hj/QxPwRjlOOq"
        };

        accountRepositoryMock.Setup(p => p.GetAsync("test@hotmail.com")).Returns(Task.FromResult(account));

        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(), options => options
                                                                                                .IncludeRuleSets("BeforeSave"));
        Assert.True(validationResult.IsValid);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_change_no_password_return_false()
    {
        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, ""), options => options
                                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Password is required.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_change_password_less_than_8_return_false()
    {
        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, UnitTestHelper.generateRandomString(7)), options => options
                                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Password length between 8 and 50.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_change_password_greater_than_50_return_false()
    {
        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, UnitTestHelper.generateRandomString(51)), options => options
                                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Password length between 8 and 50.", validationResult.Errors[0].ErrorMessage);
    }


    [Fact]
    public async Task Before_save_validate_profile_password_change_confirm_password_less_than_8_return_false()
    {
        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, UnitTestHelper.generateRandomString(8), UnitTestHelper.generateRandomString(7)), options => options
                                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Confirm Password length between 8 and 50.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_change_confirm_password_greater_than_50_return_false()
    {
        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, UnitTestHelper.generateRandomString(50), UnitTestHelper.generateRandomString(51)), options => options
                                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Confirm Password length between 8 and 50.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_change_confirm_password_not_equal_to_password_return_false()
    {
        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, UnitTestHelper.generateRandomString(25), UnitTestHelper.generateRandomString(25)), options => options
                                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Password and Confirm Password must be same.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async Task Before_save_validate_profile_password_invalid_current_password_return_false()
    {
        Account account = new()
        {
            Verified = new DateTime(),
            PasswordHash = "$2a$11$cHlJvvDHx8AZhGkRBJZCGeUYSbllmnU8y5B9JlB/hj/QxPwRjlOOq"
        };

        accountRepositoryMock.Setup(p => p.GetAsync("test@hotmail.com")).Returns(Task.FromResult(account));

        ValidationResult validationResult = await validator.ValidateAsync(CreateProfilePasswordChange(1, "Password#2", "Password#2", "Password#3"), options => options
                                                                                                .IncludeRuleSets("BeforeSave"));
        Assert.False(validationResult.IsValid);
        Assert.Equal("Current password is invalid.", validationResult.Errors[0].ErrorMessage);
    }

    private ProfilePasswordChangeRequest CreateProfilePasswordChange(int id = 1, string password = "Password#2",
        string confirmPassword = "Password#2", string currentPassword = "Password#1", string email = "test@hotmail.com")
    {
        return new ProfilePasswordChangeRequest(id, password, confirmPassword, currentPassword, email);
    }
}
