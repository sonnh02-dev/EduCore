namespace EduCore.BackEnd.Application.Interfaces.Caching
{
    public interface IRedisCacheService
    {
        Task<T?> GetAsync<T>(string key);
        Task SetAsync(string key, object value, TimeSpan? expiry = null);
        Task RemoveAsync(string key);
    }
}
