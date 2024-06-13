using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class StudioService : IStudioService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Studio> _validatorHelper;

    public StudioService(IMapper mapper,
                              IValidatorHelper<Studio> validatorHelper,
                              IMemoryCache memoryCache,
                              IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<Studio>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<Studio>>(CacheKeys.Studio, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return (await _unitOfWork.Studios.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    }

    public async Task<Studio> AddAsync(Studio studio)
    {
        await _unitOfWork.Studios.AddAsync(studio);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.Studio);

        return studio;
    }

    public void Update(Studio studio)
    {
        _unitOfWork.Studios.Update(studio);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.Studio);

        return;
    }

    public void DeleteAsync(Studio studio)
    {
        _unitOfWork.Studios.Delete(studio);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.Studio);

        return;
    }

    public async Task<Studio> GetAsync(int id)
    {
        var studio = await _unitOfWork.Studios.ByIdAsync(id);
        if (studio == null)
        {
            throw new StudioNotFoundException("Studio not found.");
        }

        return studio;
    }
}