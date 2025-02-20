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
[Route("api/v{version:apiVersion}/countries")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class CountryController(ILogger<CountryController> logger,
                         ICountryService countryService,
                         IValidator<Country> validator,
                         IMapper mapper) : BaseController<Country>(validator)
{
    private readonly ILogger<CountryController> _logger = logger;
    private readonly ICountryService _countryService = countryService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("")]
    public async Task<ActionResult<List<CountryResponse>>> GetAllCountriesAsync()
    {
        var countrys = await _countryService.GetAllAsync();
        return _mapper.Map<List<CountryResponse>>(countrys);
    }

    [HttpPost("country/add")]
    public async Task<ActionResult<CountryActionResponse>> PostAddCountryAsync([FromBody] CountryAddRequest countryAddRequest)
    {
        Country country = _mapper.Map<Country>(countryAddRequest);

        var validationResult = await Validate(country, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedCountry = await _countryService.AddAsync(country);

        return Ok(new CountryActionResponse(savedCountry.Id, savedCountry.Name));
    }

    [HttpPut("country/update")]
    public async Task<ActionResult> PutUpdateCountryAsync([FromBody] CountryUpdateRequest countryUpdateRequest)
    {
        var country = await _countryService.GetAsync(countryUpdateRequest.Id);

        country.Name = countryUpdateRequest.Name;

        var validationResult = await Validate(country, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _countryService.Update(country);

        return Ok(new CountryActionResponse(country.Id, country.Name));
    }

    [HttpDelete("country/{id}")]
    public async Task<ActionResult> DeleteCountryAsync(int id)
    {
        _countryService.DeleteAsync(await _countryService.GetAsync(id));

        return Ok(new CountryActionResponse(id, ""));
    }
}
