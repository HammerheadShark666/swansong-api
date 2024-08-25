using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public class FailedValidationResponse
{
    public List<Message> Messages { get; set; }
    public bool IsValid { get; set; }

    public FailedValidationResponse(List<ValidationFailure> rules, bool isValid)
    {
        IsValid = isValid;
        Rules = rules;
    }

    public List<ValidationFailure> Rules
    {
        set
        {
            Messages = new();
            foreach (ValidationFailure validationFailure in value)
            {
                Messages.Add(new Message(validationFailure.ErrorMessage, Severity.Error.ToString().ToLower()));
            }
        }
    }
}