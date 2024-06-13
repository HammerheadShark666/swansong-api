using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class AlbumSongService : IAlbumSongService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<AlbumSong> _validatorHelper; 

    public AlbumSongService(IMapper mapper,
                            IValidatorHelper<AlbumSong> validatorHelper,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork)
    { 
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions 

    public async Task<List<AlbumSong>> GetAlbumSongsAsync(long albumId)
    {
        return (List<AlbumSong>)await _unitOfWork.AlbumSongs.GetAlbumSongsAsync(albumId);
    }

    public async Task<AlbumSong> GetAsync(long id)
    {
        var albumSong = await _unitOfWork.AlbumSongs.ByIdAsync(id);
        if (albumSong == null)
        {
            throw new AlbumSongNotFoundException("Album Song not found.");
        }

        return albumSong;
    }

    public async Task<AlbumSong> AddAsync(AlbumSong albumSong)
    { 
        await _unitOfWork.AlbumSongs.AddAsync(albumSong);
        _unitOfWork.Complete();

        return albumSong; 
    }

    public void Update(AlbumSong albumSong)
    {
        _unitOfWork.AlbumSongs.Update(albumSong);
        _unitOfWork.Complete();

        return;
    }

    public void DeleteAsync(AlbumSong albumSong)
    {
        _unitOfWork.AlbumSongs.Delete(albumSong);
        _unitOfWork.Complete();
  
        return;
    }  

    #endregion
}