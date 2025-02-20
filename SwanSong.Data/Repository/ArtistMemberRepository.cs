using Microsoft.EntityFrameworkCore;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;
public class ArtistMemberRepository(SwanSongContext context) : IArtistMemberRepository
{
    private readonly SwanSongContext _context = context;

    public async Task<List<ArtistMember>> GetMembersByArtistAsync(long artistId)
    {
        return await _context.ArtistMembers
                               .Include(e => e.Member)
                               .Where(a => a.ArtistId.Equals(artistId))
                               .ToListAsync();
    }

    public async Task AddAsync(ArtistMember artistMember)
    {
        artistMember.AddedDate = DateTime.Now;
        await _context.ArtistMembers.AddAsync(artistMember);
    }

    public void Delete(ArtistMember artistMember)
    {
        _context.ArtistMembers.Remove(artistMember);
    }

    public async Task<ArtistMember> GetAsync(long id)
    {
        return await _context.ArtistMembers
                                .Where(a => a.Id.Equals(id))
                                .FirstOrDefaultAsync();
    }
}