using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IAlbumSongService
{
    Task<List<AlbumSong>> GetAlbumSongsAsync(long albumId);
    Task<AlbumSong> GetAsync(long id);
    Task<AlbumSong> AddAsync(AlbumSong albumSong);
    void Update(AlbumSong albumSong);
    void DeleteAsync(AlbumSong albumSong);
}