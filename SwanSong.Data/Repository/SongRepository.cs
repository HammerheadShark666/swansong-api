using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Data.Repository;

public class SongRepository(SwanSongContext context) : ISongRepository
{
    private readonly SwanSongContext _context = context;

    public void Delete(Song song)
    {
        _context.Songs.Remove(song);
    }

    public async Task<Song> ByIdAsync(long id)
    {
        return await _context.Songs.FindAsync(id);
    }
}