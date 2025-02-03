using SwanSong.Domain;
using SwanSong.Domain.Dto;
using System.Collections.Generic;

namespace SwanSong.Helper;

public class AutoMapperProfile : AutoMapper.Profile
{
    public AutoMapperProfile()
    {
        CreateMap<MemberUpdateRequest, Member>()
            .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => src.ArtistId == 0 ? null : src.ArtistId))
            .ForMember(dest => dest.BirthPlaceId, opt => opt.MapFrom(src => src.BirthPlaceId < 1 ? null : src.BirthPlaceId));
        CreateMap<Member, MemberActionResponse>();
        CreateMap<Member, MemberLookUpResponse>();
        CreateMap<Member, MemberResponse>();
        CreateMap<Member, ArtistMemberResponse>();
        CreateMap<MemberDescriptionUpdateRequest, Member>();

        CreateMap<MemberAddRequest, Member>()
            .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => src.ArtistId == 0 ? null : src.ArtistId))
            .ForMember(dest => dest.BirthPlaceId, opt => opt.MapFrom(src => src.BirthPlaceId < 1 ? null : src.BirthPlaceId));

        CreateMap<Album, ArtistAlbumResponse>();
        CreateMap<Artist, ArtistWithAlbumsResponse>()
            .ConstructUsing((artist, c) => new ArtistWithAlbumsResponse(
                artist.Id,
                artist.Name,
                artist.Description,
                artist.Photo,
                artist.FormationYear,
                artist.DisbandYear,
                artist.CountryId,
                c.Mapper.Map<List<ArtistMemberResponse>>(artist.Members),
                c.Mapper.Map<List<ArtistAlbumResponse>>(artist.Albums)
            ));

        CreateMap<ArtistDescriptionUpdateRequest, Artist>();

        CreateMap<ArtistAddRequest, Artist>()
            .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId == 0 ? null : src.CountryId))
            .ForMember(dest => dest.FormationYear, opt => opt.MapFrom(src => src.FormationYear == 0 ? null : src.FormationYear))
            .ForMember(dest => dest.DisbandYear, opt => opt.MapFrom(src => src.DisbandYear == 0 ? null : src.DisbandYear));

        CreateMap<ArtistUpdateRequest, Artist>()
            .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId == 0 ? null : src.CountryId))
            .ForMember(dest => dest.FormationYear, opt => opt.MapFrom(src => src.FormationYear == 0 ? null : src.FormationYear))
            .ForMember(dest => dest.DisbandYear, opt => opt.MapFrom(src => src.DisbandYear == 0 ? null : src.DisbandYear));

        CreateMap<Artist, ArtistActionResponse>();
        CreateMap<Artist, ArtistResponse>();
        CreateMap<Artist, ArtistLookUpResponse>()
          .ConstructUsing((artist, c) => new ArtistLookUpResponse(
              artist.Id,
              artist.Name,
              artist.Photo));

        CreateMap<AlbumAddRequest, Album>()
            .ForMember(dest => dest.LabelId, opt => opt.MapFrom(src => src.LabelId == 0 ? null : src.LabelId))
            .ForMember(dest => dest.StudioId, opt => opt.MapFrom(src => src.StudioId == 0 ? null : src.StudioId));

        CreateMap<AlbumDescriptionUpdateRequest, Album>();

        CreateMap<AlbumUpdateRequest, Album>()
            .ForMember(dest => dest.LabelId, opt => opt.MapFrom(src => src.LabelId == 0 ? null : src.LabelId))
            .ForMember(dest => dest.StudioId, opt => opt.MapFrom(src => src.StudioId == 0 ? null : src.StudioId));

        CreateMap<Album, AlbumActionResponse>();
        CreateMap<Album, AlbumResponse>()
          .ConstructUsing((album, c) => new AlbumResponse(
              album.Id,
              album.Name,
              album.Description,
              album.ArtistId,
              album.Artist.Name,
              album.ReleaseDate,
              album.RecordedDate,
              album.LabelId,
              (album.Label != null ? album.Label.Name : ""),
              album.StudioId,
              album.Producers,
              album.Arrangers,
              album.Engineers,
              album.Artwork,
              album.Photo,
              c.Mapper.Map<List<AlbumSongResponse>>(album.AlbumSongs)));

        CreateMap<Album, AlbumLookUpResponse>()
          .ConstructUsing(album => new AlbumLookUpResponse(
              album.Id,
              album.Name,
              album.Artist.Name,
              album.Photo));

        CreateMap<AlbumSongAddRequest, AlbumSong>();
        CreateMap<AlbumSongUpdateRequest, AlbumSong>();
        CreateMap<AlbumSong, AlbumSongActionResponse>();

        CreateMap<AlbumSong, AlbumSongResponse>()
            .ConstructUsing(albumSong => new AlbumSongResponse(
                albumSong.Id,
                albumSong.AlbumId,
                albumSong.SongId,
                new SongResponse(albumSong.Song.Id, albumSong.Song.Title, albumSong.Song.Length),
                albumSong.Order,
                albumSong.Side
                ));

        CreateMap<AlbumSongSongAddRequest, Song>();
        CreateMap<AlbumSongSongUpdateRequest, Song>();
        CreateMap<Song, SongActionResponse>();

        CreateMap<Song, SongResponse>()
            .ConstructUsing(song => new SongResponse(
                song.Id,
                song.Title,
                song.Length
                ));

        CreateMap<ProfilePasswordChangeRequest, ProfilePasswordChangeActionResponse>().ReverseMap();
        CreateMap<Account, ProfilePasswordChangeRequest>().ReverseMap();
        CreateMap<Account, ProfileResponse>().ReverseMap();
        CreateMap<Account, ProfileRequest>().ReverseMap();
        CreateMap<Account, JwtRefreshTokenActionResponse>().ReverseMap();
        CreateMap<Account, LoginActionResponse>().ReverseMap();
        CreateMap<RegisterRequest, Account>().ReverseMap();
        CreateMap<SwanSong.Domain.Dto.Profile, ProfileResponse>();
        CreateMap<SwanSong.Domain.Dto.JwtRefreshToken, JwtRefreshTokenActionResponse>();

        CreateMap<RecordLabel, RecordLabelResponse>();
        CreateMap<RecordLabel, RecordLabelActionResponse>();
        CreateMap<RecordLabelAddRequest, RecordLabel>();
        CreateMap<RecordLabelUpdateRequest, RecordLabel>();

        CreateMap<Country, CountryResponse>();
        CreateMap<Country, CountryActionResponse>();
        CreateMap<CountryAddRequest, Country>();
        CreateMap<CountryUpdateRequest, Country>();

        CreateMap<Studio, StudioResponse>();
        CreateMap<Studio, StudioActionResponse>();
        CreateMap<StudioAddRequest, Studio>();
        CreateMap<StudioUpdateRequest, Studio>();

        CreateMap<BirthPlace, BirthPlaceResponse>();
        CreateMap<BirthPlace, BirthPlaceActionResponse>();
        CreateMap<BirthPlaceAddRequest, BirthPlace>()
            .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId < 1 ? null : src.CountryId));
        CreateMap<BirthPlaceUpdateRequest, BirthPlace>();
    }
}