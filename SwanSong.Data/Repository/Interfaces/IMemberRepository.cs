using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository.Interfaces;

public interface IMemberRepository
{
    Task<bool> ExistsAsync(long id, string stageName);
    Task<long> CountAsync();
    Task<List<Member>> GetAllAsync(int pageNumber, int pageSize);
    Task<List<Member>> GetRandomAsync(int numberOfMembers);
    Task<Member> GetAsync(long id);
    Task<List<Member>> SearchByNameAsync(string criteria);
    Task<List<Member>> SearchByLetterAsync(string letter);
    Task<Member> UpdateMemberPhotoAsync(long id, string filename);
    Task AddAsync(Member member);
    void Update(Member member);
    void Delete(Member member);
    Task<Member> ByIdAsync(long id);
    void UpdateArtistIdsForMembers(string sql);
}