using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record ArtistAddRequest(string Name, string Photo, int? FormationYear, int? DisbandYear,
                               int? CountryId);

public record ArtistUpdateRequest(long Id, string Name, string Photo, int? FormationYear,
                                  int? DisbandYear, int? CountryId);

public record ArtistLookUpResponse(long Id, string Name, string Photo);

public record ArtistResponse(long Id, string Name, string Description, string Photo, int? FormationYear,
                             int? DisbandYear, int? CountryId, List<MemberResponse> Members, List<AlbumResponse> Albums);

public record ArtistWithAlbumsResponse(long Id, string Name, string Description, string Photo, int? FormationYear,
                             int? DisbandYear, int? CountryId, List<ArtistMemberResponse> Members, List<ArtistAlbumResponse> Albums);

public record ArtistAlbumResponse(long Id, string Name, string Photo, string ArtistName);

public record ArtistMemberResponse(long id, string StageName);

public record ArtistActionResponse(long Id);

public record ArtistPhotoActionResponse(string filename, bool IsValid);