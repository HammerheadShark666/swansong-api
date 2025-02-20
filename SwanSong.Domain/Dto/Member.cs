using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record MemberAddRequest(string StageName, string FirstName, string MiddleName,
                               string Surname, string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath,
                               int? BirthPlaceId);

public record MemberUpdateRequest(long Id, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId);

public record MemberUpdateArtistAssignedTo(long ArtistId, List<long> MembersToAdd, List<long> membersToRemove);


public record MemberWithArtistsResponse(long Id, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId, string Description, List<MemberArtistLookUpResponse> Artists);

public record MemberArtistLookUpResponse
{
    public long Id { get; init; }
    public string Name { get; init; }
    public string Photo { get; init; }
    public MemberArtistLookUpResponse() { }
}

public record MemberResponse
{
    public long Id { get; init; }
    public string StageName { get; init; }
    public string FirstName { get; init; }
    public string MiddleName { get; init; }
    public string Surname { get; init; }
    public int? BirthPlaceId { get; init; }
    public string Photo { get; init; }
    public DateTime? DateOfBirth { get; init; }
    public DateTime? DateOfDeath { get; init; }
    public string Description { get; init; }
    public List<MemberArtistLookUpResponse> Artists { get; init; }
    public MemberResponse() { }
    public MemberResponse(long Id, string StageName, string FirstName, string MiddleName,
                            string Surname, int? BirthPlaceId, string Photo, DateTime? DateOfBirth, DateTime?
                               DateOfDeath, string Description, List<MemberArtistLookUpResponse> Artists)
    { }
};

public record MemberLookUpResponse(long Id, string StageName, string Photo);

public record MemberActionResponse(long Id);

public record MemberPhotoActionResponse(string filename);

public record MemberLookUpsFormResponse(List<BirthPlaceResponse> BirthPlaces);

public record MemberDescriptionUpdateRequest(long Id, string Description);