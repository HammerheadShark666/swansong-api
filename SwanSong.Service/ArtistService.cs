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
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerArtists);
        await _unitOfWork.Artists.UpdateArtistPhotoAsync(id, newFileName);

        return newFileName;
    }

    public async Task<Artist> AddAsync(Artist artist)
    {
        await _unitOfWork.Artists.AddAsync(artist);
        _unitOfWork.Complete();

        return artist;
    }

    public void Update(Artist artist)
    {
        _unitOfWork.Artists.Update(artist);
        _unitOfWork.Complete();

        return;
    }

    public async Task DeleteAsync(Artist artist)
    {
        _unitOfWork.Artists.Delete(artist);
        _unitOfWork.Complete();

        await DeleteArtistPhotosAsync(artist.Photo);
        await DeleteMembersPhotosAsync(artist.Members);

        return;
    }

    public List<Artist> GetAll()
    {
        return _unitOfWork.Artists.GetAllForLookup().ToList();
    }

    #endregion

    #region Private Function

    private async Task DeleteMembersPhotosAsync(List<Member> members)
    {
        foreach (Member member in members)
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(member.Photo, Constants.AzureStorageContainerMembers);
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
        if (editPhoto.photoWasChanged)
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(editPhoto.originalPhotoName, container);
        }
    }

    #endregion
}