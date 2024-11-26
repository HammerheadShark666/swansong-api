using System;

namespace SwanSong.Domain.Dto;

public record MemberAddRequest(long ArtistId, string StageName, string FirstName, string MiddleName,
                               string Surname, string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath,
                               int? BirthPlaceId);

public record MemberUpdateRequest(long Id, long ArtistId, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId);

public record MemberResponse(long Id, long ArtistId, string StageName,
                             string FirstName, string MiddleName, string Surname,
                             string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath, string Description);

public record MemberLookUpResponse(long Id, string StageName, string Photo);

public record MemberActionResponse(long Id);

public record MemberPhotoActionResponse(string filename);