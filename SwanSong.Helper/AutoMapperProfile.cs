using SwanSong.Domain;
using SwanSong.Domain.Dto;
using System.Collections.Generic;

namespace SwanSong.Helper;

public class AutoMapperProfile : AutoMapper.Profile
{
    public AutoMapperProfile()
    {
        CreateMap<MemberUpdateRequest, Member>()
            .ForMember(dest => dest.BirthPlaceId, opt => opt.MapFrom(src => src.BirthPlaceId < 1 ? null : src.BirthPlaceId));
        CreateMap<Member, MemberActionResponse>();
        CreateMap<Member, MemberLookUpResponse>();
        CreateMap<Member, MemberResponse>();
        CreateMap<Member, ArtistMemberMemberResponse>();

        CreateMap<Member, MemberWithArtistsResponse>()
            .ConstructUsing((member, c) => new MemberWithArtistsResponse(
                member.Id,
                member.StageName,
                member.FirstName,
                member.MiddleName,
                member.Surname,
                member.Photo,
                member.DateOfBirth,
                member.DateOfDeath,
                member.BirthPlaceId,
                member.Description,
                c.Mapper.Map<List<MemberArtistLookUpResponse>>(member.ArtistMembers)
            ));

        CreateMap<ArtistMember, ArtistMemberResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.MemberId))
            .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => src.ArtistId))
            .ForMember(dest => dest.Member,
                    opt => opt.MapFrom(src => new Member
                    {
                        Id = src.Member.Id,
                        StageName = src.Member.StageName,
                        Surname = src.Member.Surname,
                        MiddleName = src.Member.MiddleName,
                        FirstName = src.Member.FirstName,
                        DateOfBirth = src.Member.DateOfBirth,
                        DateOfDeath = src.Member.DateOfDeath,
                        Photo = src.Member.Photo
                    }));

        CreateMap<ArtistMemberAddRequest, ArtistMember>()
            .ForMember(dest => dest.ArtistId, opt => opt.MapFrom(src => src.ArtistId))
            .ForMember(dest => dest.Member,
                    opt => opt.MapFrom(src => new Member
                    {
                        Id = src.Member.Id,
                        StageName = src.Member.StageName,
                        Surname = src.Member.Surname,
                        MiddleName = src.Member.MiddleName,
                        FirstName = src.Member.FirstName,
                        DateOfBirth = src.Member.DateOfBirth,
                        DateOfDeath = src.Member.DateOfDeath
                    }));

        CreateMap<ArtistMember, MemberArtistLookUpResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Artist.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Artist.Name))
            .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Artist.Photo));

        CreateMap<ArtistMemberUpdateRequest, Member>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.memberId))
           .ForMember(dest => dest.StageName, opt => opt.MapFrom(src => src.StageName))
           .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
           .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
           .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
           .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
           .ForMember(dest => dest.DateOfDeath, opt => opt.MapFrom(src => src.DateOfDeath));

        CreateMap<MemberDescriptionUpdateRequest, Member>();

        CreateMap<MemberAddRequest, Member>()
            .ForMember(dest => dest.BirthPlaceId, opt => opt.MapFrom(src => src.BirthPlaceId < 1 ? null : src.BirthPlaceId));

        CreateMap<Artist, ArtistWithAlbumsResponse>()
            .ConstructUsing((artist, c) => new ArtistWithAlbumsResponse(
                artist.Id,
                artist.Name,
                artist.Description,
                artist.Photo,
                artist.FormationYear,
                artist.DisbandYear,
                artist.CountryId,
                c.Mapper.Map<List<ArtistMemberLookupResponse>>(artist.ArtistMembers),
                c.Mapper.Map<List<AlbumLookUpResponse>>(artist.Albums)
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
        CreateMap<Artist, ArtistResponse>()
            .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.ArtistMembers));

        CreateMap<ArtistMember, ArtistMemberLookupResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Member.Id))
            .ForMember(dest => dest.StageName, opt => opt.MapFrom(src => src.Member.StageName))
            .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Member.Photo));

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