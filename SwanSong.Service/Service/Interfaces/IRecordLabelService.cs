using SwanSong.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface IRecordLabelService
{
    Task<RecordLabel> GetAsync(int id);
    Task<List<RecordLabel>> GetAllAsync();
    Task<RecordLabel> AddAsync(RecordLabel recordLabel);
    void Update(RecordLabel recordLabel);
    void DeleteAsync(RecordLabel recordLabel);
}