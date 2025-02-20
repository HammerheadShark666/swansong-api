using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Linq;

namespace SwanSong.Business.Validator;

public class ArtistMemberValidator : BaseValidator<ArtistMember>
{
    private readonly IMemberRepository _artistMemberRepository;
    private readonly IArtistRepository _artistRepository;

    public ArtistMemberValidator(IMemberRepository artistMemberRepository, IArtistRepository artistRepository)
    {
        _artistMemberRepository = artistMemberRepository;
        _artistRepository = artistRepository;

        RuleSet("BeforeSave", () =>
        {
            RuleFor(artistMember => artistMember.ArtistId)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Artist is required.");

            RuleFor(artistMember => artistMember.Member.StageName)
                .NotEmpty()
                    .WithMessage("Stage name is required.")
                .Length(1, 150)
                    .When(x => x.Member.StageName.Count() > 0, ApplyConditionTo.CurrentValidator)
                        .WithMessage("Stage name length between 1 and 150.");

            RuleFor(artistMember => artistMember.Member.Surname)
                .NotEmpty()
                    .WithMessage("Surname is required.")
                .Length(1, 50)
                    .When(x => x.Member.Surname.Count() > 0, ApplyConditionTo.CurrentValidator)
                    .WithMessage("Surname must be 50 characters or less.");

            RuleFor(artistMember => artistMember.Member.MiddleName)
                .Length(0, 50)
                    .When(x => x.Member.MiddleName != null && x.Member.MiddleName.Count() > 0, ApplyConditionTo.CurrentValidator)
                    .WithMessage("Middle name must be 50 characters or less.");

            RuleFor(artistMember => artistMember.Member.FirstName)
                .NotEmpty()
                    .WithMessage("First name is required.")
                .Length(1, 50)
                    .When(x => x.Member.FirstName.Count() > 0, ApplyConditionTo.CurrentValidator)
                    .WithMessage("First name must be 50 characters or less.");

            RuleFor(artistMember => artistMember.Member.DateOfBirth)
                .GreaterThan(new DateTime(1900, 1, 1))
                .When(x => x.Member.DateOfBirth != null, ApplyConditionTo.CurrentValidator);

            RuleFor(artistMember => artistMember.Member.DateOfDeath)
                .GreaterThan(m => m.Member.DateOfBirth)
                    .When(x => x.Member.DateOfBirth != null, ApplyConditionTo.CurrentValidator)
                        .WithMessage("Date of death must be after date of birth.");

            RuleFor(artistMember => artistMember.Member.DateOfDeath)
                .GreaterThan(new DateTime(1900, 1, 1))
                    .When(x => x.Member.DateOfDeath != null, ApplyConditionTo.CurrentValidator);
        });
    }
}
