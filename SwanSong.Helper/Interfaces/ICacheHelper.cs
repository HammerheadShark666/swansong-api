using Microsoft.Extensions.Caching.Memory;

namespace SwanSong.Helper.Interfaces;

public interface ICacheHelper
{
    void RemoveFromCache(string cacheKey, IMemoryCache _memoryCache);
}
