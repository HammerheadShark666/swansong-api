using Asp.Versioning;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[Authorize]
[Route("api/v{version:apiVersion}/studios")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class StudioController(ILogger<StudioController> logger,
                             IStudioService studioService,
                             IValidator<Studio> validator,
                             IMapper mapper) : BaseController<Studio>(validator)
{
    private readonly ILogger<StudioController> _logger = logger;
    private readonly IStudioService _studioService = studioService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("")]
    public async Task<ActionResult<List<StudioResponse>>> GetAllStudiosAsync()
    {
        var studios = await _studioService.GetAllAsync();
        return _mapper.Map<List<StudioResponse>>(studios);
    }

    [HttpPost("studio/add")]
    public async Task<ActionResult<StudioActionResponse>> PostAddStudioAsync([FromBody] StudioAddRequest studioAddRequest)
    {
        Studio studio = _mapper.Map<Studio>(studioAddRequest);

        var validationResult = await Validate(studio, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedStudio = await _studioService.AddAsync(studio);

        return Ok(new StudioActionResponse(savedStudio.Id, savedStudio.Name));
    }

    [HttpPut("studio/update")]
    public async Task<ActionResult> PutUpdateStudioAsync([FromBody] StudioUpdateRequest studioUpdateRequest)
    {
        var studio = await _studioService.GetAsync(studioUpdateRequest.Id);

        studio.Name = studioUpdateRequest.Name;

        var validationResult = await Validate(studio, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _studioService.Update(studio);

        return Ok(new StudioActionResponse(studio.Id, studio.Name));
    }

    [HttpDelete("studio/{id}")]
    public async Task<ActionResult> DeleteStudioAsync(int id)
    {
        _studioService.DeleteAsync(await _studioService.GetAsync(id));

        return Ok(new StudioActionResponse(id, ""));
    }
}