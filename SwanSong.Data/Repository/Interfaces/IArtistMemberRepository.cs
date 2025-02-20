using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;
public interface IArtistMemberRepository
{
    Task<List<ArtistMember>> GetMembersByArtistAsync(long artistId);
    Task AddAsync(ArtistMember artistMember);
    void Delete(ArtistMember artistMember);
    Task<ArtistMember> GetAsync(long id);
}