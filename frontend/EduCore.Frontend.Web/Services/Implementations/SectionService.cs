using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using System.Collections;

namespace EduCore.Frontend.Web.Services.Implementations
{


    public class SectionService : ISectionService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public SectionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SectionViewModel>> GetAllSectionByCourseId(int courseId)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7004/api/Section/getListSectionByCourseId/1");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<SectionViewModel>>();
        }
    }


}
