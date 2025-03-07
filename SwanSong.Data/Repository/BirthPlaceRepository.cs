﻿using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class BirthPlaceRepository(SwanSongContext context) : IBirthPlaceRepository
{
    private readonly SwanSongContext _context = context;

    public async Task<bool> ExistsAsync(string name)
    {
        return await _context.BirthPlaces
                                .AsNoTracking()
                                .AnyAsync(a => a.Name.Equals(name));
    }

    public async Task<bool> ExistsAsync(int ignoreId, string name)
    {
        return await _context.BirthPlaces
                                .AsNoTracking()
                                .AnyAsync(a => a.Name.Equals(name) && !a.Id.Equals(ignoreId));
    }

    public async Task AddAsync(BirthPlace birthPlace)
    {
        birthPlace.AddedDate = DateTime.Now;
        await _context.BirthPlaces.AddAsync(birthPlace);
    }

    public void Update(BirthPlace birthPlace)
    {
        birthPlace.ModifiedDate = DateTime.Now;
        _context.BirthPlaces.Update(birthPlace);
    }

    public void Delete(BirthPlace birthPlace)
    {
        _context.BirthPlaces.Remove(birthPlace);
    }

    public async Task<IEnumerable<BirthPlace>> AllAsync()
    {
        return await _context.BirthPlaces
                                .AsNoTracking()
                                .ToListAsync();
    }

    public async Task<BirthPlace> ByIdAsync(int id)
    {
        return await _context.BirthPlaces.FindAsync(id);
    }
}