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

public class StudioService(IMapper mapper,
                          IValidatorHelper<Studio> validatorHelper,
                          IMemoryCache memoryCache,
                          IUnitOfWork unitOfWork) : IStudioService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<Studio> _validatorHelper = validatorHelper;

    public async Task<List<Studio>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<Studio>>(CacheKeys.Studio, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return [.. (await _unitOfWork.Studios.AllAsync()).OrderBy(c => c.Name)];
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
        return await _unitOfWork.Studios.ByIdAsync(id) ?? throw new StudioNotFoundException("Studio not found.");
    }
}