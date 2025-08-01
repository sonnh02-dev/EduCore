﻿using EduCore.Frontend.Shared.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;

namespace EduCore.Frontend.Shared.Services.Implementations
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public SubCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //public async Task<List<SubCategoryDTO>> GetAllSubCategory()
        //{
        //    var response = await _httpClient.GetAsync("https://localhost:7004/SubCategories");
        //    response.EnsureSuccessStatusCode();
        //    return await response.Content.ReadFromJsonAsync<List<SubCategoryDTO>>();
        //}
    }
}
