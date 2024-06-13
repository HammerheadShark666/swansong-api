using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IBirthPlaceService
{
    Task<BirthPlace> GetAsync(int id);
    Task<List<BirthPlace>> GetAllAsync(); 
    Task<BirthPlace> AddAsync(BirthPlace birthPlace);
    void Update(BirthPlace birthPlace);
    void DeleteAsync(BirthPlace birthPlace);
}