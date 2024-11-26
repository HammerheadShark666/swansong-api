using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using SwanSong.Helper;

namespace SwanSong.Api.Helpers.Extensions;

public static class AppExtensions
{
    public static void ConfigureSwagger(this WebApplication webApplication)
    {
        if (webApplication.Environment.IsDevelopment())
        {
            webApplication.UseSwagger();
            webApplication.UseSwaggerUI(options =>
            {
                var descriptions = webApplication.DescribeApiVersions();

                // Build a swagger endpoint for each discovered API version
                foreach (var description in descriptions)
                {
                    var url = $"/swagger/{description.GroupName}/swagger.json";
                    var name = description.GroupName.ToUpperInvariant();
                    options.SwaggerEndpoint(url, name);
                }
            });
        }
    }

    public static void ConfigureCors(this WebApplication webApplication)
    {
        webApplication.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .WithOrigins(EnvironmentVariablesHelper.VueFrontEndBaseUrl,
                         EnvironmentVariablesHelper.NextJsFrontEndBaseUrl,
                         EnvironmentVariablesHelper.ProductionFrontEndBaseUrl));

    }
}
