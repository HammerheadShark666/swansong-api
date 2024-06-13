using SwanSong.Domain;
using SwanSong.Domain.Dto;
using System.Collections.Generic;

namespace SwanSong.Helper.Interfaces;

public interface IAlbumHelper
{
    List<AlbumLookUpResponse> GetAlbumLookUps(List<Album> albums);
    string GetAlbumLength(List<AlbumSong> albumSongs);
}
