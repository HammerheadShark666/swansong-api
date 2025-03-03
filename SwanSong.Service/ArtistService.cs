﻿using AutoMapper;
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

public class ArtistService(IMapper mapper,
                           IPhotoHelper photoHelper,
                           IValidatorHelper<Artist> validatorHelper,
                           IMemoryCache memoryCache,
                           IUnitOfWork unitOfWork,
                           IAzureStorageBlobHelper azureStorageHelper) : IArtistService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<Artist> _validatorHelper = validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper = azureStorageHelper;
    public readonly IPhotoHelper _photoHelper = photoHelper;

    #region Public Functions

    public async Task<long> CountAsync()
    {
        return await _unitOfWork.Artists.CountAsync();
    }

    public async Task<List<Artist>> GetAllAsync(PaginationFilter filter)
    {
        return (await _unitOfWork.Artists.GetAllAsync(filter.PageNumber, filter.PageSize)).OrderBy(a => a.Name).ToList();
    }

    public async Task<List<Artist>> GetRandomAsync(int numberOfArtists)
    {
        return (await _unitOfWork.Artists.GetRandomAsync(numberOfArtists)).OrderBy(a => a.Name).ToList();
    }

    public async Task<List<Artist>> SearchByNameAsync(string criteria)
    {
        return (List<Artist>)await _unitOfWork.Artists.SearchByNameAsync(criteria);
    }

    public async Task<Artist> GetArtistFullDetailsAsync(long id)
    {
        return await _unitOfWork.Artists.GetArtistFullDetailsAsync(id) ?? throw new ArtistNotFoundException("Artist not found.");
    }

    public async Task<List<Artist>> SearchByAlphaNumericAsync(string alphanumeric)
    {
        return (List<Artist>)await _unitOfWork.Artists.SearchByAlphaNumericAsync(alphanumeric);
    }

    public async Task<Artist> GetAsync(long id)
    {
        return await _unitOfWork.Artists.ByIdAsync(id) ?? throw new ArtistNotFoundException("Artist not found.");
    }

    public async Task<string> UpdateArtistPhotoAsync(long id, IFormFile file)
    {
        var artist = await _unitOfWork.Artists.ByIdAsync(id) ?? throw new ArtistNotFoundException("Artist not found.");
        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = artist.Photo;

        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerArtists, newFileName);
        await _unitOfWork.Artists.UpdateArtistPhotoAsync(id, newFileName);

        if (!String.IsNullOrEmpty(originalFileName))
            await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerArtists);

        return newFileName;
    }

    public async Task UpdateDescriptionAsync(long id, string description)
    {
        Artist existingArtist = await GetAsync(id) ?? throw new ArtistNotFoundException("Artist not found (" + id + ")");

        existingArtist.Description = description;
        existingArtist.ModifiedDate = DateTime.Now;

        _unitOfWork.Artists.Update(existingArtist);
        _unitOfWork.Complete();

        return;
    }

    public async Task<Artist> AddAsync(Artist artist)
    {
        await _unitOfWork.Artists.AddAsync(artist);
        _unitOfWork.Complete();

        return artist;
    }

    public async Task Update(Artist artist)
    {
        var existingArtist = await _unitOfWork.Artists.ByIdAsync(artist.Id) ?? throw new ArtistNotFoundException("Artist not found.");

        existingArtist.Name = artist.Name;
        existingArtist.FormationYear = artist.FormationYear;
        existingArtist.DisbandYear = artist.DisbandYear;
        existingArtist.CountryId = artist.CountryId;

        _unitOfWork.Artists.Update(await UpdateExistingArtist(artist));
        _unitOfWork.Complete();

        return;
    }

    public async Task DeleteAsync(Artist artist)
    {
        _unitOfWork.Artists.Delete(artist);
        _unitOfWork.Complete();

        await DeleteArtistPhotosAsync(artist.Photo);
        await DeleteArtistMembersPhotosAsync(artist.ArtistMembers.ToList());

        return;
    }

    public List<Artist> GetAll()
    {
        return _unitOfWork.Artists.GetAllForLookup().ToList();
    }

    #endregion

    #region Private Function

    private async Task DeleteArtistMembersPhotosAsync(List<ArtistMember> artistMembers)
    {
        foreach (ArtistMember artistMember in artistMembers)
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(artistMember.Member.Photo, Constants.AzureStorageContainerMembers);
    }

    private async Task DeleteArtistPhotosAsync(string artistPhotoFileName)
    {
        if (_photoHelper.NotDefaultImage(artistPhotoFileName, Constants.DefaultArtistPhotoFileName))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(artistPhotoFileName, Constants.AzureStorageContainerArtists);
        }
    }

    private async Task DeleteOriginalFileAsync(string originalFileName, string newFileName, string container)
    {
        EditPhoto editPhoto = _photoHelper.WasPhotoEdited(originalFileName, newFileName, Constants.DefaultArtistPhotoFileName);
        if (editPhoto.PhotoWasChanged)
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(editPhoto.OriginalPhotoName, container);
        }
    }

    private async Task<Artist> UpdateExistingArtist(Artist artist)
    {
        var existingArtist = await _unitOfWork.Artists.ByIdAsync(artist.Id) ?? throw new ArtistNotFoundException("Artist not found.");

        existingArtist.Name = artist.Name;
        existingArtist.FormationYear = artist.FormationYear;
        existingArtist.DisbandYear = artist.DisbandYear;
        existingArtist.CountryId = artist.CountryId;

        return existingArtist;
    }

    #endregion
}