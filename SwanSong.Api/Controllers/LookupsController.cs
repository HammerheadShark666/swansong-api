using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[Authorize]
[Route("api/v{version:apiVersion}/lookups")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class LookupsController(ILogger<LookupsController> logger,
                              IRecordLabelService recordLabelService,
                              ICountryService countryService,
                              IStudioService studioService,
                              IBirthPlaceService birthPlaceService,
                              IMapper mapper) : Controller
{
    private readonly ILogger<LookupsController> _logger = logger;
    private readonly IRecordLabelService _recordLabelService = recordLabelService;
    private readonly ICountryService _countryService = countryService;
    private readonly IStudioService _studioService = studioService;
    private readonly IBirthPlaceService _birthPlaceService = birthPlaceService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("")]
    public async Task<ActionResult<LookupsResponse>> GetLookupsAsync()
    {
        var birthPlaces = _mapper.Map<List<BirthPlaceResponse>>(await _birthPlaceService.GetAllAsync());
        var countries = _mapper.Map<List<CountryResponse>>(await _countryService.GetAllAsync());
        var recordLabels = _mapper.Map<List<RecordLabelResponse>>(await _recordLabelService.GetAllAsync());
        var studios = _mapper.Map<List<StudioResponse>>(await _studioService.GetAllAsync());

        var lookups = new LookupsResponse(countries, recordLabels, studios, birthPlaces);

        return Ok(lookups);
    }

}
