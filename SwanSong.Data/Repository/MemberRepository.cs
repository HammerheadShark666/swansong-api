﻿using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class MemberRepository : IMemberRepository
{
    private readonly SwanSongContext _context;

    public MemberRepository(SwanSongContext context)
    {
        _context = context;
    }

    public async Task<List<Member>> GetAllAsync(int pageNumber, int pageSize)
    {
        return await _context.Members
                             .OrderBy(a => a.StageName)
                             .Skip((pageNumber - 1) * pageSize)
                             .Take(pageSize)
                             .AsNoTracking()
                             .ToListAsync();
    }

    public async Task<List<Member>> GetRandomAsync(int numberOfMembers)
    {
        return await _context.Members            
                                .OrderByDescending(x => Guid.NewGuid()).Take(numberOfMembers)
                                .AsNoTracking()
                                .ToListAsync();
    }

    public async Task<List<Member>> SearchByNameAsync(string criteria)
    {
        return await (from member in _context.Members
                      where member.StageName.ToUpper().Contains(criteria.ToUpper())
                      select member)
                      .AsNoTracking()
                      .ToListAsync();
    }

    public async Task<List<Member>> SearchByLetterAsync(string letter)
    {
        return await (from member in _context.Members
                      where member.StageName.ToUpper().Substring(0, 1).Equals(letter.ToUpper())
                      select member)
                      .AsNoTracking()
                      .ToListAsync();
    }

    public async Task<long> CountAsync()
    {
        return await _context.Members
                                .AsNoTracking()
                                .CountAsync();
    }

    public async Task<IEnumerable<Member>> GetMembersByArtistAsync(long artistId)
    {
        return await (from member in _context.Members
                      where member.ArtistId.Equals(artistId)
                      orderby member.StageName
                      select member)
                      .AsNoTracking()
                      .ToListAsync();
    }

    public async Task<Member> GetAsync(long id)
    {
        return await _context.Members
                                .Include(p => p.BirthPlace)
                                .Where(a => a.Id.Equals(id))
                                .FirstOrDefaultAsync();
    } 

    public async Task<bool> ExistsAsync(long id, long? artistId, string stageName)
    {
        return await _context.Members
                               .Where(a => a.StageName.Equals(stageName)
                                    && a.ArtistId.Equals(artistId)
                                    && !a.Id.Equals(id))
                               .AsNoTracking()
                               .AnyAsync();
    } 

    public async Task<Member> UpdateMemberPhotoAsync(long id, string filename)
    {
        Member member = await GetAsync(id);

        member.Photo = filename;
        _context.SaveChanges();

        return member;
    } 

    public async Task<bool> ExistsAsync(long id, string stageName)
    {
        return await _context.Members
                               .Where(a => a.StageName.Equals(stageName)
                                    && !a.Id.Equals(id))
                               .AsNoTracking()
                               .AnyAsync();
    }

    public async Task AddAsync(Member member)
    {
        await _context.Members.AddAsync(member);
    }

    public void Update(Member member)
    {
        _context.Members.Update(member);
    }

    public void Delete(Member member)
    {
        _context.Members.Remove(member);
    }
 
    public async Task<Member> ByIdAsync(long id)
    {
        return await _context.Members.FindAsync(id);
    }
}