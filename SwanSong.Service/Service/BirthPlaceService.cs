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

public class BirthPlaceService : IBirthPlaceService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<BirthPlace> _validatorHelper;

    public BirthPlaceService(IMapper mapper,
                             IValidatorHelper<BirthPlace> validatorHelper,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<BirthPlace>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<BirthPlace>>(CacheKeys.BirthPlace, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return (await _unitOfWork.BirthPlaces.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    } 

    public async Task<BirthPlace> AddAsync(BirthPlace birthPlace)
    {
        await _unitOfWork.BirthPlaces.AddAsync(birthPlace);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.BirthPlace);

        return birthPlace; 
    }

    public void Update(BirthPlace birthPlace)
    {
        _unitOfWork.BirthPlaces.Update(birthPlace);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.BirthPlace);

        return;
    }

    public void DeleteAsync(BirthPlace birthPlace)
    {
        _unitOfWork.BirthPlaces.Delete(birthPlace);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.BirthPlace);

        return; 
    }
 
    public async Task<BirthPlace> GetAsync(int id)
    {
        var birthPlace = await _unitOfWork.BirthPlaces.ByIdAsync(id);
        if (birthPlace == null)
        {
            throw new BirthPlaceNotFoundException("BirthPlace not found.");
        }

        return birthPlace;
    }
}