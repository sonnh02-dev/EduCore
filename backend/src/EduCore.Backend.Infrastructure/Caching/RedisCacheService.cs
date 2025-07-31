using EduCore.BackEnd.Application.Interfaces.Caching;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Text.Json;

namespace EduCore.BackEnd.Infrastructure.Caching;
public class RedisCacheService : IRedisCacheService
{
    private readonly IDistributedCache _cache;

    public RedisCacheService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        var value = await _cache.GetStringAsync(key);
        return string.IsNullOrEmpty(value) ? default : JsonConvert.DeserializeObject<T>(value);
    }

    public async Task SetAsync(string key, object value, TimeSpan? expiry = null)
    {
        var options = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = expiry ?? TimeSpan.FromMinutes(30)
        };
        string json = ((JsonElement)value).GetRawText();
        await _cache.SetStringAsync(key, json, options);

    }

    public async Task RemoveAsync(string key)
    {
        await _cache.RemoveAsync(key);
    }
}
   
   