using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SwanSong.Api.Helpers.Extensions;
using SwanSong.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

builder.Services.ConfigureApplicationInsights();
builder.Services.ConfigureMvc();
builder.Services.ConfigureControllers();
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureDI();
builder.Services.ConfigureVersioning();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.ConfigureSwagger();
app.UseRouting();
app.ConfigureCors();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseMiddleware<JwtMiddleware>();
app.MapControllers();

app.Run();