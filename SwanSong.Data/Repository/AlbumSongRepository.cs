﻿using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class AlbumSongRepository(SwanSongContext context) : IAlbumSongRepository
{
    private readonly SwanSongContext _context = context;

    public async Task<IEnumerable<AlbumSong>> GetAlbumSongsAsync(long albumId)
    {
        return await _context.AlbumSongs
                                .Include(e => e.Song)
                                    .Where(e => e.AlbumId.Equals(albumId))
                                .OrderBy(e => e.Side)
                                    .ThenBy(e => e.Order)
                                .AsNoTracking()
                                .ToListAsync();
    }

    public async Task<bool> ExistsAsync(long? albumId, string title)
    {
        return await _context.AlbumSongs
                               .Where(a => a.Song.Title.ToUpper().Equals(title.ToUpper())
                                    && a.AlbumId.Equals(albumId))
                               .AsNoTracking()
                               .AnyAsync();
    }

    public async Task<bool> ExistsAsync(long id, long? albumId, string title)
    {
        return await _context.AlbumSongs
                               .Where(a => a.Song.Title.ToUpper().Equals(title.ToUpper())
                                    && a.AlbumId.Equals(albumId)
                                        && !a.Id.Equals(id))
                               .AsNoTracking()
                               .AnyAsync();
    }

    public async Task<bool> TrackPositionExistsAsync(long albumId, long songId, int? side, int? order)
    {
        return await _context.AlbumSongs
                               .Where(a => a.AlbumId.Equals(albumId)
                                    && !a.Id.Equals(songId)
                                        && a.Side.Equals(side)
                                            && a.Order.Equals(order))
                               .AsNoTracking()
                               .AnyAsync();
    }

    public async Task AddAsync(AlbumSong albumSong)
    {
        albumSong.AddedDate = DateTime.Now;
        await _context.AlbumSongs.AddAsync(albumSong);
    }

    public void Update(AlbumSong albumSong)
    {
        albumSong.ModifiedDate = DateTime.Now;
        _context.AlbumSongs.Update(albumSong);
    }

    public void Delete(AlbumSong albumSong)
    {
        _context.AlbumSongs.Remove(albumSong);
    }

    public async Task<AlbumSong> ByIdAsync(long id)
    {
        return await _context.AlbumSongs
                        .Include(e => e.Song)
                            .Where(e => e.Id.Equals(id))
                        .FirstOrDefaultAsync();
    }
}