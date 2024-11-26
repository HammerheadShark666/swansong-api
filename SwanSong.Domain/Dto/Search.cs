using System.Collections.Generic;

namespace SwanSong.Domain.Dto;
public class Search
{
    public record SearchResponse(List<AlbumLookUpResponse> albums, List<ArtistLookUpResponse> artists, List<MemberLookUpResponse> members);
}