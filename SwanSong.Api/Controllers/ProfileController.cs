﻿using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[Route("api/v{version:apiVersion}/profile")]
public class ProfileController : Controller
{
    private readonly ILogger<ProfileController> _logger;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IProfileService _profileService; 

    public ProfileController(IProfileService profileService, IHttpContextAccessor httpContextAccessor, ILogger<ProfileController> logger)
    {
        _httpContextAccessor = httpContextAccessor;
        _profileService = profileService; 
        _logger = logger;
    }

    [Authorize]
    [HttpPut("update")]
    public async Task<ActionResult<ProfileActionResponse>> PutUpdateProfileAsync(ProfileRequest profileRequest)
    {
        await _profileService.UpdateAsync(LoggedInAccount().Id, profileRequest);
        return Ok();
    }

    [Authorize]
    [HttpGet("")]
    public async Task<ActionResult<ProfileResponse>> GetProfileAsync()
    { 
        return Ok(await _profileService.GetAsync(LoggedInAccount().Id)); 
    }

    private Account LoggedInAccount()
    {
        var context = _httpContextAccessor.HttpContext;
        return (Account)context.Items["Account"];
    }
}
