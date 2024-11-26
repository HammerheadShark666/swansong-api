using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Helper.Interfaces;

public interface IAlbumHelper
{
    // List<AlbumLookUpResponse> GetAlbumLookUps(List<Album> albums);
    string GetAlbumLength(List<AlbumSong> albumSongs);
}
