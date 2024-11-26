using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record AlbumAddRequest(string Name, long? ArtistId, DateTime? ReleaseDate, DateTime? RecordedDate,
                              int? LabelId, int? StudioId, string Producers, string Arrangers, string Engineers,
                              string Artwork, string Photo, List<AlbumSongResponse> Songs);

public record AlbumUpdateRequest(long Id, string Name, long? ArtistId, DateTime? ReleaseDate,
                                 DateTime? RecordedDate, int? LabelId, int? StudioId, string Producers,
                                 string Arrangers, string Engineers, string Artwork, string Photo, List<AlbumSongResponse> Songs);

public record AlbumLookUpResponse(long Id, string Name, string ArtistName, string Photo);
public record AlbumResponse(long Id, string Name, string Description, long? ArtistId, string ArtistName,
                            DateTime? ReleaseDate, DateTime? RecordedDate, int? LabelId, string LabelName, int? StudioId,
                            string Producers, string Arrangers, string Engineers, string Artwork,
                            string Photo, List<AlbumSongResponse> Songs);
public record AlbumActionResponse(long Id);

public record AlbumPhotoActionResponse(string filename);