using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api/v{version:apiVersion}")]
public class AuthenticateController(IAuthenticateService authenticateService,
                                    IHttpContextAccessor httpContextAccessor,
                                    IValidatorHelper<LoginRequest> validatorHelper,
                                    ILogger<ProfileController> logger,
                                    IMapper mapper) : Controller
{
    private readonly ILogger<ProfileController> _logger = logger;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IAuthenticateService _authenticateService = authenticateService;
    private readonly IValidatorHelper<LoginRequest> _validatorHelper = validatorHelper;
    private readonly IMapper _mapper = mapper;

    [HttpPost("login")]
    public async Task<ActionResult<LoginActionResponse>> PostLoginAsync(LoginRequest loginRequest)
    {
        await _validatorHelper.ValidateAsync(loginRequest, Constants.ValidationEventBeforeSave);

        var authenticated = await _authenticateService.AuthenticateAsync(loginRequest, AuthenticationHelper.IpAddress(Request, HttpContext));
        var profile = _mapper.Map<ProfileResponse>(authenticated.Profile);

        return Ok(new LoginActionResponse(authenticated.JwtToken, authenticated.RefreshToken, profile));
    }

    [HttpPost("refresh-token")]
    public async Task<ActionResult<JwtRefreshTokenActionResponse>> PostRefreshTokenAsync(JwtRefreshTokenRequest jwtRefreshTokenRequest)
    {
        var jwtToken = await _authenticateService.RefreshTokenAsync(jwtRefreshTokenRequest.RefreshToken, AuthenticationHelper.IpAddress(Request, HttpContext));
        return Ok(_mapper.Map<JwtRefreshTokenActionResponse>(jwtToken));
    }
}