using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Filter;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SwanSong.Helper.PhotoHelper;

namespace SwanSong.Service;

public class AlbumService : IAlbumService
{
    public readonly ICacheHelper _cacheHelper;
    public readonly IPhotoHelper _photoHelper;
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Album> _validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper; 

    public AlbumService(IMapper mapper,
                        ICacheHelper cacheHelper,
                        IPhotoHelper photoHelper,
                        IValidatorHelper<Album> validatorHelper,
                        IMemoryCache memoryCache,
                        IUnitOfWork unitOfWork,
                        IAzureStorageBlobHelper azureStorageHelper)
    {
        _azureStorageHelper = azureStorageHelper;
        _validatorHelper = validatorHelper;
        _photoHelper = photoHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _cacheHelper = cacheHelper;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<long> CountAsync()
    {
        return await _unitOfWork.Albums.CountAsync();
    }

    public async Task<List<Album>> GetAllAsync(PaginationFilter filter)
    {
        return await _unitOfWork.Albums.GetAllAsync(filter.PageNumber, filter.PageSize);
    } 

    public async Task<List<Album>> GetRandomAsync(int numberOfAlbums)
    {
        return (await _unitOfWork.Albums.GetRandomAsync(numberOfAlbums)).OrderBy(a => a.Name).ToList();
    } 

    public async Task<List<Album>> SearchByNameAsync(string criteria)
    {
        return (List<Album>)await _unitOfWork.Albums.SearchByNameAsync(criteria);
    } 
  
    public async Task<List<Album>> SearchByLetterAsync(string letter)
    {
        return (List<Album>)await _unitOfWork.Albums.SearchByLetterAsync(letter);
    } 

    public async Task<List<Album>> GetAlbumsForArtistAsync(long artistId)
    {
        return (List<Album>)await _unitOfWork.Albums.GetAlbumsForArtistAsync(artistId);
    } 

    public async Task<Album> GetAsync(long id)
    {
        var album = await _unitOfWork.Albums.GetAsync(id);
        if (album == null)
            throw new AlbumNotFoundException("Album not found.");

        return album;
    }

    public async Task<Album> AddAsync(Album album)
    { 
        await _unitOfWork.Albums.AddAsync(album);
        _unitOfWork.Complete(); 

        return album;
    } 

    public void Update(Album album)
    {
        _unitOfWork.Albums.Update(album);
        _unitOfWork.Complete();

        return;
    }

    public async Task DeleteAsync(Album album)
    {
        _unitOfWork.Albums.Delete(album);
        _unitOfWork.Complete();  

        if (_photoHelper.NotDefaultImage(album.Photo, Constants.DefaultAlbumPhotoFileName))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(album.Photo, Constants.AzureStorageContainerAlbums);
        }

        return;
    }

    public async Task<string> UpdateAlbumPhotoAsync(long id, IFormFile file)
    {
        var album = await _unitOfWork.Albums.GetAsync(id);
        if (album == null) 
            throw new AlbumNotFoundException("Album not found."); 

        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = album.Photo;

        await _unitOfWork.Albums.UpdateAlbumPhotoAsync(id, newFileName);

        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerAlbums, newFileName);
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerAlbums);

        return newFileName;
    }

    #endregion

    #region Private Functions  

    private async Task DeleteOriginalFileAsync(string originalFileName, string newFileName, string container)
    {
        EditPhoto editPhoto = _photoHelper.WasPhotoEdited(originalFileName, newFileName, Constants.DefaultAlbumPhotoFileName);
        if (editPhoto.photoWasChanged)
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(editPhoto.originalPhotoName, container);
        }
    } 

    #endregion
}