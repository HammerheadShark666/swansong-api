using Microsoft.AspNetCore.Http;
using SwanSong.Domain;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IArtistService
{
    Task<List<Artist>> SearchByNameAsync(string criteria);
    Task<List<Artist>> SearchByAlphaNumericAsync(string alphanumeric);
    Task<long> CountAsync();
    Task<List<Artist>> GetAllAsync(PaginationFilter filter);
    Task<List<Artist>> GetRandomAsync(int numberOfArtists);
    Task<Artist> GetArtistFullDetailsAsync(long id);
    Task<Artist> GetAsync(long id);
    Task<string> UpdateArtistPhotoAsync(long id, IFormFile file);
    List<Artist> GetAll();
    Task<Artist> AddAsync(Artist artist);
    Task Update(Artist artist);
    Task DeleteAsync(Artist artist);
    Task UpdateDescriptionAsync(long id, string description);
}