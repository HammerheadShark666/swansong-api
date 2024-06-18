using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[Controller]
public class BaseController<T> : ControllerBase where T : class
{
    private readonly IValidator<T> _validator;

    public BaseController(IValidator<T> validator)
    {
        _validator = validator;
    }

    public async Task<FailedValidationResponse> Validate(T album, string validationEvent)
    {
        var validationResult = await _validator.ValidateAsync(album, options => options.IncludeRuleSets(validationEvent));
        if (!validationResult.IsValid) 
            return new FailedValidationResponse(validationResult.Errors, false);  

        return null;
    }
}