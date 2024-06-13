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

public class CountryService : ICountryService
{ 
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper; 
    public readonly IValidatorHelper<Country> _validatorHelper;

    public CountryService(IMapper mapper,
                          IValidatorHelper<Country> validatorHelper,
                          IMemoryCache memoryCache,
                          IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<Country>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<Country>>(CacheKeys.Country, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return (await _unitOfWork.Countries.AllAsync()).OrderBy(c => c.Name).ToList();
        });
    }

    public async Task<Country> AddAsync(Country country)
    {
        await _unitOfWork.Countries.AddAsync(country);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.Country);

        return country;
    }

    public void Update(Country country)
    {
        _unitOfWork.Countries.Update(country);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.Country);

        return;
    }

    public void DeleteAsync(Country country)
    {
        _unitOfWork.Countries.Delete(country);
        _unitOfWork.Complete();

        _memoryCache.Remove(CacheKeys.Country);

        return;
    } 

    public async Task<Country> GetAsync(int id)
    {
        var country = await _unitOfWork.Countries.ByIdAsync(id);
        if (country == null)
        {
            throw new CountryNotFoundException("Country not found.");
        }

        return country;
    }
}