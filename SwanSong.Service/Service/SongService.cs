using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class SongService : ISongService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Song> _validatorHelper;
    public SongService(IMapper mapper,
                       IValidatorHelper<Song> validatorHelper,
                       IMemoryCache memoryCache,
                       IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<Song> GetSongAsync(long id)
    {
        var song = await _unitOfWork.Songs.ByIdAsync(id);
        if (song == null) 
            throw new SongNotFoundException("Song not found."); 

        return song;
    }

    public void Delete(Song song)
    {
        _unitOfWork.Songs.Delete(song);
        _unitOfWork.Complete(); 

        return;
    }

    #endregion
}