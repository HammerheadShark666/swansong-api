using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Helper.Interfaces;

public interface IAlbumHelper
{
    string GetAlbumLength(List<AlbumSong> albumSongs);
}
