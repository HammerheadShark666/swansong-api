using System;

namespace SwanSong.Domain.Dto;

public record ArtistMemberAddRequest
{
    public long Id { get; init; }
    public long MemberId { get; init; }
    public long ArtistId { get; init; }
    public ArtistMemberMemberRequest Member { get; init; }
    public ArtistMemberAddRequest() { }
    public ArtistMemberAddRequest(long ArtistMemberId, long ArtistId, Member Member)
    { }
};

public record ArtistMemberMemberRequest(long Id, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId);
public record ArtistMemberUpdateRequest(long artistMemberId, long memberId, string StageName, string FirstName, string MiddleName,
                               string Surname, DateTime? DateOfBirth, DateTime? DateOfDeath);

public record ArtistMemberActionResponse(string message);

public record ArtistMemberAddActionResponse(long artistMemberId, long memberId);

public record ArtistMemberMemberResponse(long Id, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId);

public record ArtistMemberResponse
{
    public long Id { get; init; }
    public long MemberId { get; init; }
    public long ArtistId { get; init; }
    public ArtistMemberMemberResponse Member { get; init; }
    public ArtistMemberResponse() { }
    public ArtistMemberResponse(long ArtistMemberId, long ArtistId, Member Member)
    { }
};