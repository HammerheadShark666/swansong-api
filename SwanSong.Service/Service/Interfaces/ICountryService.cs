using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface ICountryService
{
    Task<Country> GetAsync(int id);
    Task<List<Country>> GetAllAsync();
    Task<Country> AddAsync(Country country);
    void Update(Country country);
    void DeleteAsync(Country country);
}