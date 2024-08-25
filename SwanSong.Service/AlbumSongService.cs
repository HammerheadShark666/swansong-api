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

public class AlbumSongService(IMapper mapper,
                              IValidatorHelper<AlbumSong> validatorHelper,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork) : IAlbumSongService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<AlbumSong> _validatorHelper = validatorHelper;

    #region Public Functions 

    public async Task<List<AlbumSong>> GetAlbumSongsAsync(long albumId)
    {
        return (List<AlbumSong>)await _unitOfWork.AlbumSongs.GetAlbumSongsAsync(albumId);
    }

    public async Task<AlbumSong> GetAsync(long id)
    {
        return await _unitOfWork.AlbumSongs.ByIdAsync(id) ?? throw new AlbumSongNotFoundException("Album Song not found.");
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