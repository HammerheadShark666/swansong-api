using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using SwanSong.Helper;

namespace SwanSong.Api.Helpers.Extensions;

public static class AppExtensions
{
    public static void ConfigureSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var descriptions = app.DescribeApiVersions();

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

    public static void ConfigureCors(this WebApplication app)
    {
        app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .WithOrigins(EnvironmentVariablesHelper.FrontEndBaseUrl)
            );

    }
}
