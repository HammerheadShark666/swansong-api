namespace SwanSong.Helper;

public static class Constants
{
    public const string DefaultImage = "music-note.jpg";
    public const string VerifyUrl = "{0}/register/verify-email/{1}";
    public const string ResetUrl = "{0}/reset-password/{1}";
    public const string AlreadyReadyRegisteredUrl = "{0}/forgot-password";

    public const string AzureStorageContainerAlbums = "albums";
    public const string AzureStorageContainerArtists = "artists";
    public const string AzureStorageContainerMembers = "members";

    public static string DefaultArtistPhotoFileName = "default-artist-image.jpg";
    public static string DefaultAlbumPhotoFileName = "default-album-image.jpg";
    public static string DefaultMemberPhotoFileName = "default-member-image.jpg";
    public const string FileExtensionJpg = "jpg";
    public const string ContentTypeImageJpg = "image/jpeg";

    public const string DatabaseConnectionString = "SQLAZURECONNSTR_SWANSONG";
    public const string AzureStorageConnectionString = "AZURE_STORAGE_CONNECTION_STRING";

    public const string JwtSettingsSercret = "JWT_SETTINGS_SECRET";
    public const string JwtSettingsRefreshTokenTtl = "JWT_SETTINGS_REFRESH_TOKEN_TTL";
    public const string JwtSettingsTokenExpiryMinutes = "JWT_SETTINGS_TOKEN_EXPIRY_MINUTES";
    public const string JwtSettingsRefreshTokenExpiryDays = "JWT_SETTINGS_REFRESH_TOKEN_EXPIRY_DAYS";
    public const string JwtSettingsPasswordTokenExpiryDays = "JWT_SETTINGS_RESET_PASSWORD_TOKEN_EXPIRY_DAYS";

    public const string NumberOfRandomRecords = "NUMBER_OF_RANDOM_RECORDS";

    public const string RegisterSenderEmail = "DEFAULT_FROM_EMAIL";
    public const string SmtpGmailServer = "SMTP_GMAIL_SERVER";
    public const string SmtpGmailPort = "SMTP_GMAIL_PORT";
    public const string SmtpGmailUsername = "SMTP_GMAIL_USERNAME";
    public const string SmtpGmailPassword = "SMTP_GMAIL_PASSWORD";

    public const string VueFrontEndBaseUrl = "VUE_FRONT_END_BASE_URL";
    public const string NextJsFrontEndBaseUrl = "NEXTJS_FRONT_END_BASE_URL";
    public const string NextJsFrontEndAdminBaseUrl = "NEXTJS_FRONT_END_ADMIN_BASE_URL";
    public const string ProductionFrontEndBaseUrl = "PRODUCTION_FRONT_END_BASE_URL";

    public const string ApplicationInsightsConnectionString = "APPLICATIONINSIGHTS_CONNECTION_STRING";

    public const string ValidationEventBeforeSave = "BeforeSave";
    public const string ValidationEventBeforeSaveDescription = "BeforeSaveDescription";

    public const int MaxFileSize = 500000;
}