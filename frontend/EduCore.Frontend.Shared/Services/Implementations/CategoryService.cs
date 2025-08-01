using EduCore.Frontend.Shared.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace EduCore.Frontend.Shared.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }

        public async Task<CategoryViewModel> GetCategoryByCateId(int cateId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Category/GetCategoryByCateId/{cateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CategoryViewModel>();

        }
        public async Task<List<CategoryViewModel>> GetListCategory()
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Category/GetListCategory");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CategoryViewModel>>();
        }
        public async Task<bool> UpdateCategory(CategoryViewModel category)
        {
            var jsonContent = JsonSerializer.Serialize(category);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_baseAPIRoute}/Category/UpdateCategory", httpContent);
            return response.IsSuccessStatusCode;
        }
        public async Task DeleteCategory(int categoryId)
        {
            var response = await _httpClient.DeleteAsync($"{_baseAPIRoute}/Category/deleteCategory/{categoryId}");
            response.EnsureSuccessStatusCode();
        }
        public async Task AddCategory(CategoryViewModel category)
        {
            var jsonContent = JsonSerializer.Serialize(category);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_baseAPIRoute}/Category/AddCategory", httpContent);
            response.EnsureSuccessStatusCode();
        }
        public async Task<int> GetNumberCategories()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/Category/$count").Result.Content.ReadFromJsonAsync<int>();
        }
    }
}
