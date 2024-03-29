﻿using SwanSong.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IAlbumSongService
{
    Task<List<AlbumSongResponse>> GetAlbumSongsAsync(long albumId); 
    Task<AlbumSongActionResponse> AddAsync(AlbumSongAddRequest albumSongAddRequest);
    Task<AlbumSongActionResponse> UpdateAsync(AlbumSongUpdateRequest albumSongReuest);
    Task<AlbumSongActionResponse> DeleteAsync(long id);
}