using AutoMapper;
using SwanSong.Domain;
using SwanSong.Helper.Interfaces;
using System;
using System.Collections.Generic;

namespace SwanSong.Helper.Domain;

public class AlbumHelper(IMapper mapper) : IAlbumHelper
{
    public readonly IMapper _mapper = mapper;

    //public List<AlbumLookUpResponse> GetAlbumLookUps(List<Album> albums)
    //{
    //    List<AlbumLookUpResponse> albumLookUpResponses = _mapper.Map<List<AlbumLookUpResponse>>(albums);

    //    for (int i = 0; i < albumLookUpResponses.Count; i++)
    //    {
    //        List<AlbumSong> albumSongs = albums.First(a => a.Id.Equals(albumLookUpResponses[i].Id)).AlbumSongs.ToList();
    //        albumLookUpResponses[i] = albumLookUpResponses[i] with { Tracks = albumSongs.Count().ToString(), Length = GetAlbumLength(albumSongs.ToList()) };
    //    }

    //    return albumLookUpResponses;
    //}

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