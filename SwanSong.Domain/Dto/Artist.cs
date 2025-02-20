using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record ArtistAddRequest(string Name, string Photo, int? FormationYear, int? DisbandYear,
                               int? CountryId);

public record ArtistUpdateRequest(long Id, string Name, string Photo, int? FormationYear,
                                  int? DisbandYear, int? CountryId);

public record ArtistLookUpResponse
{
    public long Id;

    public string Name;

    public string Photo;

    public ArtistLookUpResponse() { }

    public ArtistLookUpResponse(long Id, string Name, string Photo) { }
};

public record ArtistResponse
{
    public long Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public string Photo { get; init; }
    public int? FormationYear { get; init; }
    public int? DisbandYear { get; init; }
    public int? CountryId { get; init; }
    public List<ArtistMemberLookupResponse> Members { get; init; } //v Artist
    public List<AlbumLookUpResponse> Albums { get; init; }

    public ArtistResponse() { }
};

public record ArtistWithAlbumsResponse(long Id, string Name, string Description, string Photo, int? FormationYear,
                             int? DisbandYear, int? CountryId, List<ArtistMemberLookupResponse> Members, List<AlbumLookUpResponse> Albums);

public record ArtistMemberLookupResponse
{
    public long Id { get; init; }
    public string StageName { get; init; }
    public string Photo { get; init; }
    public ArtistMemberLookupResponse() { }
}

public record ArtistActionResponse(long Id);

public record ArtistLookUpsFormResponse(List<CountryResponse> Countries);

public record ArtistDescriptionUpdateRequest(long Id, string Description);