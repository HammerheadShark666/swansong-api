using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IStudioService
{
    Task<Studio> GetAsync(int id);
    Task<List<Studio>> GetAllAsync();
    Task<Studio> AddAsync(Studio studio);
    void Update(Studio studio);
    void DeleteAsync(Studio studio);
}