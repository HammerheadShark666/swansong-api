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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SwanSong.Helper.PhotoHelper;

namespace SwanSong.Service;

public class AlbumService(IMapper mapper,
                          ICacheHelper cacheHelper,
                          IPhotoHelper photoHelper,
                          IValidatorHelper<Album> validatorHelper,
                          IMemoryCache memoryCache,
                          IUnitOfWork unitOfWork,
                          IAzureStorageBlobHelper azureStorageHelper) : IAlbumService
{
    public readonly ICacheHelper _cacheHelper = cacheHelper;
    public readonly IPhotoHelper _photoHelper = photoHelper;
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<Album> _validatorHelper = validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper = azureStorageHelper;

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
        return [.. (await _unitOfWork.Albums.GetRandomAsync(numberOfAlbums)).OrderBy(a => a.Name)];
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
        return await _unitOfWork.Albums.GetAsync(id) ?? throw new AlbumNotFoundException("Album not found.");
    }

    public async Task<Album> AddAsync(Album album)
    {
        await _unitOfWork.Albums.AddAsync(album);
        _unitOfWork.Complete();

        return album;
    }

    public async Task UpdateAsync(Album album)
    {
        _unitOfWork.Albums.Update(await UpdateExistingAlbum(album));
        _unitOfWork.Complete();

        return;
    }

    public async Task UpdateDescriptionAsync(long id, string description)
    {
        Album existingAlbum = await GetAsync(id) ?? throw new AlbumNotFoundException("Album not found (" + id + ")");

        existingAlbum.Description = description;
        existingAlbum.ModifiedDate = DateTime.Now;

        _unitOfWork.Albums.Update(existingAlbum);
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
        var album = await _unitOfWork.Albums.GetAsync(id) ?? throw new AlbumNotFoundException("Album not found.");

        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = album.Photo;

        await _unitOfWork.Albums.UpdateAlbumPhotoAsync(id, newFileName);
        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerAlbums, newFileName);

        if (!String.IsNullOrEmpty(originalFileName))
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

    private async Task<Album> UpdateExistingAlbum(Album album)
    {
        Album existingAlbum = await GetAsync(album.Id) ?? throw new AlbumNotFoundException("Album not found (" + album.Name + ")");

        existingAlbum.Name = album.Name;
        existingAlbum.ArtistId = album.ArtistId;
        existingAlbum.ReleaseDate = album.ReleaseDate;
        existingAlbum.RecordedDate = album.RecordedDate;
        existingAlbum.LabelId = album.LabelId;
        existingAlbum.StudioId = album.StudioId;
        existingAlbum.Producers = album.Producers;
        existingAlbum.Arrangers = album.Arrangers;
        existingAlbum.Artwork = album.Artwork;
        existingAlbum.ModifiedDate = DateTime.Now;

        return existingAlbum;
    }

    #endregion
}