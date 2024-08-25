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

public class CountryService(IMapper mapper,
                            IValidatorHelper<Country> validatorHelper,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork) : ICountryService
{
    public readonly IMemoryCache _memoryCache = memoryCache;
    public readonly IUnitOfWork _unitOfWork = unitOfWork;
    public readonly IMapper _mapper = mapper;
    public readonly IValidatorHelper<Country> _validatorHelper = validatorHelper;

    public async Task<List<Country>> GetAllAsync()
    {
        return await _memoryCache.GetOrCreateAsync<List<Country>>(CacheKeys.Country, async cache =>
        {
            cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
            return [.. (await _unitOfWork.Countries.AllAsync()).OrderBy(c => c.Name)];
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
        return await _unitOfWork.Countries.ByIdAsync(id) ?? throw new CountryNotFoundException("Country not found.");
    }
}