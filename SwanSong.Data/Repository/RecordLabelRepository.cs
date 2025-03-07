﻿using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class RecordLabelRepository(SwanSongContext context) : IRecordLabelRepository
{
    private readonly SwanSongContext _context = context;

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.RecordLabels
                                .AsNoTracking()
                                .AnyAsync(a => a.Name.Equals(name));
    }

    public async Task<bool> ExistsAsync(int ignoreId, string name)
    {
        return await _context.RecordLabels
                                .AsNoTracking()
                                .AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
    }

    public async Task AddAsync(RecordLabel recordLabel)
    {
        recordLabel.AddedDate = DateTime.Now;
        await _context.RecordLabels.AddAsync(recordLabel);
    }

    public void Update(RecordLabel recordLabel)
    {
        recordLabel.ModifiedDate = DateTime.Now;
        _context.RecordLabels.Update(recordLabel);
    }

    public void Delete(RecordLabel recordLabel)
    {
        _context.RecordLabels.Remove(recordLabel);
    }

    public async Task<IEnumerable<RecordLabel>> AllAsync()
    {
        return await _context.RecordLabels
                                .AsNoTracking()
                                .ToListAsync();
    }

    public async Task<RecordLabel> ByIdAsync(int id)
    {
        return await _context.RecordLabels.FindAsync(id);
    }
}