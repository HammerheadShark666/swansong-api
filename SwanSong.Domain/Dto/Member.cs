using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record MemberAddRequest(long? ArtistId, string StageName, string FirstName, string MiddleName,
                               string Surname, string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath,
                               int? BirthPlaceId);

public record MemberUpdateRequest(long Id, long? ArtistId, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId);

public record MemberUpdateArtistAssignedTo(long ArtistId, List<long> MembersToAdd, List<long> membersToRemove);

public record MemberResponse(long Id, long ArtistId, string StageName,
                             string FirstName, string MiddleName, string Surname, int? BirthPlaceId,
                             string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath, string Description);

public record MemberLookUpResponse(long Id, string StageName, string Photo);

public record MemberActionResponse(long Id);

public record MemberPhotoActionResponse(string filename);

public record MemberLookUpsFormResponse(List<BirthPlaceResponse> BirthPlaces);

public record MemberDescriptionUpdateRequest(long Id, string Description);