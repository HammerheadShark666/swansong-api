using Microsoft.Extensions.Caching.Memory;
using SwanSong.Helper.Interfaces;

namespace SwanSong.Helper;

public class CacheHelper : ICacheHelper
{
    public void RemoveFromCache(string cacheKey, IMemoryCache _memoryCache)
    {
        if (cacheKey != null)
        {
            _memoryCache.Remove(cacheKey);
        }
    }
}
