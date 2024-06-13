using Microsoft.AspNetCore.Http;
using SwanSong.Domain;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IMemberService
{
    Task<List<Member>> SearchByNameAsync(string criteria);
    Task<List<Member>> SearchByLetterAsync(string letter);
    Task<List<Member>> GetMembersByArtistAsync(long artistId);
    Task<long> CountAsync();
    Task<List<Member>> GetAllAsync(PaginationFilter filter);
    Task<List<Member>> GetRandomAsync(int numberOfMembers);
    Task<Member> GetAsync(long id);
    Task<string> UpdateMemberPhotoAsync(long id, IFormFile file);
    Task DeleteAsync(Member member);
    Task<Member> AddAsync(Member member);
    void Update(Member member);
}