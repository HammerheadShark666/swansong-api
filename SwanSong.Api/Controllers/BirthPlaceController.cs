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
[Route("api/v{version:apiVersion}/birth-places")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class BirthPlaceController(ILogger<BirthPlaceController> logger,
                            IBirthPlaceService birthPlaceService,
                            IValidator<BirthPlace> validator,
                            IMapper mapper) : BaseController<BirthPlace>(validator)
{
    private readonly ILogger<BirthPlaceController> _logger = logger;
    private readonly IBirthPlaceService _birthPlaceService = birthPlaceService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("")]
    public async Task<ActionResult<List<BirthPlaceResponse>>> GetAllBirthPlacesAsync()
    {
        var birthPlaces = await _birthPlaceService.GetAllAsync();
        return _mapper.Map<List<BirthPlaceResponse>>(birthPlaces);
    }

    [HttpPost("birth-place/add")]
    public async Task<ActionResult<BirthPlaceActionResponse>> PostAddBirthPlaceAsync([FromBody] BirthPlaceAddRequest birthPlaceAddRequest)
    {
        BirthPlace birthPlace = _mapper.Map<BirthPlace>(birthPlaceAddRequest);

        var validationResult = await Validate(birthPlace, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedBirthPlace = await _birthPlaceService.AddAsync(birthPlace);

        return Ok(new BirthPlaceActionResponse(savedBirthPlace.Id, savedBirthPlace.Name));
    }

    [HttpPut("birth-place/update")]
    public async Task<ActionResult> PostUpdateBirthPlaceAsync([FromBody] BirthPlaceUpdateRequest birthPlaceUpdateRequest)
    {
        var birthPlace = await _birthPlaceService.GetAsync(birthPlaceUpdateRequest.Id);

        birthPlace.Name = birthPlaceUpdateRequest.Name;

        if (birthPlaceUpdateRequest.CountryId > 0)
            birthPlace.CountryId = birthPlaceUpdateRequest.CountryId;

        var validationResult = await Validate(birthPlace, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _birthPlaceService.Update(birthPlace);

        return Ok(new BirthPlaceActionResponse(birthPlace.Id, birthPlace.Name));
    }


    [HttpDelete("birth-place/{id}")]
    public async Task<ActionResult<BirthPlaceActionResponse>> DeleteBirthPlaceAsync(int id)
    {
        _birthPlaceService.DeleteAsync(await _birthPlaceService.GetAsync(id));

        return Ok(new BirthPlaceActionResponse(id, "Birth place deleted."));
    }
}