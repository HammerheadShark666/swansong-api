using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface ISongService
{
    Task<Song> GetSongAsync(long id);
    void Delete(Song song);
}