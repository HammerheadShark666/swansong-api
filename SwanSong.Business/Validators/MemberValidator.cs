using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Linq;

namespace SwanSong.Business.Validator;

public class MemberValidator : BaseValidator<Member>
{
    private readonly IMemberRepository _artistMemberRepository;
    private readonly IArtistRepository _artistRepository;

    public MemberValidator(IMemberRepository artistMemberRepository, IArtistRepository artistRepository)
    {
        _artistMemberRepository = artistMemberRepository;
        _artistRepository = artistRepository;

        RuleSet("BeforeSave", () =>
        {

            RuleFor(member => member.StageName)
                .NotEmpty()
                    .WithMessage("Stage name is required.")
                .Length(1, 150)
                    .When(x => x.StageName.Count() > 0, ApplyConditionTo.CurrentValidator)
                        .WithMessage("Stage name length between 1 and 150.");

            RuleFor(member => member.Surname)
                .NotEmpty()
                    .WithMessage("Surname is required.")
                .Length(1, 50)
                    .When(x => x.Surname.Count() > 0, ApplyConditionTo.CurrentValidator)
                    .WithMessage("Surname must be 50 characters or less.");

            RuleFor(member => member.MiddleName)
                .Length(0, 50)
                    .When(x => x.MiddleName != null && x.MiddleName.Count() > 0, ApplyConditionTo.CurrentValidator)
                    .WithMessage("Middle name must be 50 characters or less.");

            RuleFor(member => member.FirstName)
                .NotEmpty()
                    .WithMessage("First name is required.")
                .Length(1, 50)
                    .When(x => x.FirstName.Count() > 0, ApplyConditionTo.CurrentValidator)
                    .WithMessage("First name must be 50 characters or less.");

            RuleFor(member => member.DateOfBirth)
                .GreaterThan(new DateTime(1900, 1, 1))
                .When(x => x.DateOfBirth != null, ApplyConditionTo.CurrentValidator);

            RuleFor(member => member.DateOfDeath)
                .GreaterThan(m => m.DateOfBirth)
                    .When(x => x.DateOfBirth != null, ApplyConditionTo.CurrentValidator)
                        .WithMessage("Date of death must be after date of birth.");

            RuleFor(member => member.DateOfDeath)
                .GreaterThan(new DateTime(1900, 1, 1))
                    .When(x => x.DateOfDeath != null, ApplyConditionTo.CurrentValidator);
        });
    }
}
