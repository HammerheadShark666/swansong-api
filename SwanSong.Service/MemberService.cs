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

public class MemberService(IMapper mapper,
                           ICacheHelper cacheHelper,
                           IPhotoHelper photoHelper,
                           IValidatorHelper<Member> validatorHelper,
                           IMemoryCache memoryCache,
                           IUnitOfWork unitOfWork,
                           IAzureStorageBlobHelper azureStorageHelper) : IMemberService
{
    public readonly ICacheHelper _cacheHelper = cacheHelper;
    public readonly IPhotoHelper _photoHelper = photoHelper;
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<Member> _validatorHelper = validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper = azureStorageHelper;

    #region Public Functions

    public async Task<long> CountAsync()
    {
        return await _unitOfWork.Members.CountAsync();
    }

    public async Task<List<Member>> GetAllAsync(PaginationFilter filter)
    {
        return await _unitOfWork.Members.GetAllAsync(filter.PageNumber, filter.PageSize);
    }

    public async Task<List<Member>> GetRandomAsync(int numberOfMembers)
    {
        return [.. (await _unitOfWork.Members.GetRandomAsync(numberOfMembers)).OrderBy(a => a.StageName)];
    }

    public async Task<List<Member>> SearchByNameAsync(string criteria)
    {
        return await _unitOfWork.Members.SearchByNameAsync(criteria);
    }

    public async Task<List<Member>> SearchByLetterAsync(string letter)
    {
        return await _unitOfWork.Members.SearchByLetterAsync(letter);
    }

    public async Task<List<Member>> GetMembersByArtistAsync(long artistId)
    {
        return (List<Member>)await _unitOfWork.Members.GetMembersByArtistAsync(artistId);
    }

    public async Task<Member> GetAsync(long id)
    {
        return await _unitOfWork.Members.GetAsync(id) ?? throw new MemberNotFoundException("Member not found.");
    }

    public async Task<Member> AddAsync(Member member)
    {
        await _unitOfWork.Members.AddAsync(member);
        _unitOfWork.Complete();

        return member;
    }

    public void Update(Member member)
    {
        _unitOfWork.Members.Update(member);
        _unitOfWork.Complete();

        return;
    }

    public async Task DeleteAsync(Member member)
    {
        _unitOfWork.Members.Delete(member);
        _unitOfWork.Complete();

        if (_photoHelper.NotDefaultImage(member.Photo, Constants.DefaultMemberPhotoFileName))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(member.Photo, Constants.AzureStorageContainerMembers);
        }

        return;
    }

    public async Task<string> UpdateMemberPhotoAsync(long id, IFormFile file)
    {
        var member = await _unitOfWork.Members.GetAsync(id) ?? throw new MemberNotFoundException("Member not found.");
        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = member.Photo;

        await _unitOfWork.Members.UpdateMemberPhotoAsync(id, newFileName);

        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerMembers, newFileName);
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerMembers);

        return newFileName;
    }

    #endregion

    #region Private Functions 

    private async Task DeleteOriginalFileAsync(string originalFileName, string newFileName, string container)
    {
        EditPhoto editPhoto = _photoHelper.WasPhotoEdited(originalFileName, newFileName, Constants.DefaultMemberPhotoFileName);
        if (editPhoto.photoWasChanged)
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(editPhoto.originalPhotoName, container);
        }
    }

    #endregion
}