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
[Route("api/v{version:apiVersion}/record-labels")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class RecordLabelController(ILogger<RecordLabelController> logger,
                                   IRecordLabelService recordLabelService,
                                   IValidator<RecordLabel> validator,
                                   IMapper mapper) : BaseController<RecordLabel>(validator)
{
    private readonly ILogger<RecordLabelController> _logger = logger;
    private readonly IRecordLabelService _recordLabelService = recordLabelService;
    private readonly IMapper _mapper = mapper;

    [HttpGet("")]
    public async Task<ActionResult<List<RecordLabelResponse>>> GetAllRecordLabelsAsync()
    {
        var recordLabels = await _recordLabelService.GetAllAsync();
        return _mapper.Map<List<RecordLabelResponse>>(recordLabels);
    }

    [HttpPost("record-label/add")]
    public async Task<ActionResult<RecordLabelActionResponse>> PostAddRecordLabelAsync([FromBody] RecordLabelAddRequest recordLabelAddRequest)
    {
        RecordLabel recordLabel = _mapper.Map<RecordLabel>(recordLabelAddRequest);

        var validationResult = await Validate(recordLabel, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        var savedRecordLabel = await _recordLabelService.AddAsync(recordLabel);

        return Ok(new RecordLabelActionResponse(savedRecordLabel.Id, savedRecordLabel.Name));
    }

    [HttpPut("record-label/update")]
    public async Task<ActionResult> PutUpdateRecordLabelAsync([FromBody] RecordLabelUpdateRequest recordLabelUpdateRequest)
    {
        var recordLabel = await _recordLabelService.GetAsync(recordLabelUpdateRequest.Id);

        recordLabel.Name = recordLabelUpdateRequest.Name;

        var validationResult = await Validate(recordLabel, Constants.ValidationEventBeforeSave);
        if (validationResult != null)
            return BadRequest(validationResult);

        _recordLabelService.Update(recordLabel);

        return Ok(new RecordLabelActionResponse(recordLabel.Id, recordLabel.Name));
    }

    [HttpDelete("record-label/{id}")]
    public async Task<ActionResult> DeleteRecordLabelAsync(int id)
    {
        _recordLabelService.DeleteAsync(await _recordLabelService.GetAsync(id));

        return Ok();
    }
}