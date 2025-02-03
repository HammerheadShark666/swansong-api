using Microsoft.AspNetCore.Http;
using SwanSong.Domain;
using SwanSong.Helper.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IAlbumService
{
    Task<List<Album>> SearchByNameAsync(string criteria);
    Task<List<Album>> SearchByLetterAsync(string letter);
    Task<List<Album>> GetAlbumsForArtistAsync(long artistId);
    Task<long> CountAsync();
    Task<List<Album>> GetAllAsync(PaginationFilter filter);
    Task<List<Album>> GetRandomAsync(int numberOfAlbums);
    Task<Album> GetAsync(long id);
    Task<string> UpdateAlbumPhotoAsync(long id, IFormFile file);
    Task DeleteAsync(Album album);
    Task<Album> AddAsync(Album album);
    Task UpdateAsync(Album album);
    Task UpdateDescriptionAsync(long id, string description);
}