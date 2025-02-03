using System;

namespace SwanSong.Helper;

public class EnvironmentVariablesHelper
{
    public static string ApplicationInsightsConnectionString = Environment.GetEnvironmentVariable(Constants.ApplicationInsightsConnectionString);

    public static string VueFrontEndBaseUrl = Environment.GetEnvironmentVariable(Constants.VueFrontEndBaseUrl);
    public static string NextJsFrontEndBaseUrl = Environment.GetEnvironmentVariable(Constants.NextJsFrontEndBaseUrl);
    public static string NextJsFrontEndAdminBaseUrl = Environment.GetEnvironmentVariable(Constants.NextJsFrontEndAdminBaseUrl);
    public static string ProductionFrontEndBaseUrl = Environment.GetEnvironmentVariable(Constants.ProductionFrontEndBaseUrl);

    public static string JwtSettingsSercret = Environment.GetEnvironmentVariable(Constants.JwtSettingsSercret);
    public static int JwtSettingsRefreshTokenTtl = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenTtl));
    public static int JwtSettingsTokenExpiryMinutes = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsTokenExpiryMinutes));
    public static int JwtSettingsRefreshTokenExpiryDays = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenExpiryDays));
    public static int JwtSettingsPasswordTokenExpiryDays = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsPasswordTokenExpiryDays));

    public static int NumberOfRandomRecords = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.NumberOfRandomRecords));

    public static string RegisterSenderEmail = Environment.GetEnvironmentVariable(Constants.RegisterSenderEmail);

    public static string SmtpGmailServer = Environment.GetEnvironmentVariable(Constants.SmtpGmailServer);
    public static int SmtpGmailPort = Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.SmtpGmailPort));
    public static string SmtpGmailUsername = Environment.GetEnvironmentVariable(Constants.SmtpGmailUsername);
    public static string SmtpGmailPassword = Environment.GetEnvironmentVariable(Constants.SmtpGmailPassword);

    public static string AzureStorageConnectionString = Environment.GetEnvironmentVariable(Constants.AzureStorageConnectionString);
}