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

public class RecordLabelService(IMapper mapper,
                                IValidatorHelper<RecordLabel> validatorHelper,
                                IMemoryCache memoryCache,
                                IUnitOfWork unitOfWork) : IRecordLabelService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<RecordLabel> _validatorHelper = validatorHelper;

    public async Task<List<RecordLabel>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<RecordLabel>>(CacheKeys.RecordLabel, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return [.. (await _unitOfWork.RecordLabels.AllAsync()).OrderBy(c => c.Name)];
        });
    }

    public async Task<RecordLabel> AddAsync(RecordLabel recordLabel)
    {
        await _unitOfWork.RecordLabels.AddAsync(recordLabel);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.RecordLabel);

        return recordLabel;
    }

    public void Update(RecordLabel recordLabel)
    {
        _unitOfWork.RecordLabels.Update(recordLabel);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.RecordLabel);

        return;
    }

    public void DeleteAsync(RecordLabel recordLabel)
    {
        _unitOfWork.RecordLabels.Delete(recordLabel);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.RecordLabel);

        return;
    }

    public async Task<RecordLabel> GetAsync(int id)
    {
        return await _unitOfWork.RecordLabels.ByIdAsync(id) ?? throw new RecordLabelNotFoundException("RecordLabel not found.");
    }
}