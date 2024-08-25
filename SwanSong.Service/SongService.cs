using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class SongService(IMapper mapper,
                         IValidatorHelper<Song> validatorHelper,
                         IMemoryCache memoryCache,
                         IUnitOfWork unitOfWork) : ISongService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<Song> _validatorHelper = validatorHelper;

    #region Public Functions

    public async Task<Song> GetSongAsync(long id)
    {
        return await _unitOfWork.Songs.ByIdAsync(id) ?? throw new SongNotFoundException("Song not found.");
    }

    public void Delete(Song song)
    {
        _unitOfWork.Songs.Delete(song);
        _unitOfWork.Complete();

        return;
    }

    #endregion
}