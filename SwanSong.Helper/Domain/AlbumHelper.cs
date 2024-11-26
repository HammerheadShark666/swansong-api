using SwanSong.Domain;
using SwanSong.Helper.Interfaces;
using System;
using System.Collections.Generic;

namespace SwanSong.Helper.Domain;

public class AlbumHelper() : IAlbumHelper
{
    public string GetAlbumLength(List<AlbumSong> albumSongs)
    {
        TimeSpan time = new();

        foreach (AlbumSong albumSong in albumSongs)
        {
            try
            {
                string[] timeParts = albumSong.Song.Length.Split(':');
                TimeSpan t = new(0, int.Parse(timeParts[0]), int.Parse(timeParts[1]));
                time = time.Add(t);
            }
            catch { }
        }

        return time.ToString();
    }
}