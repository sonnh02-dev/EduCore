using EduCore.Frontend.Shared.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace EduCore.Frontend.Shared.Services.Implementations
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute;

        public EnrollmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseAPIRoute = "https://localhost:7004/api";
        }


        public async Task<int> AddEnrollment(AddEnrollmentViewModel createEnrollment)
        {
            var response = await _httpClient.PostAsync($"{_baseAPIRoute}/Enrollment/addEnrollment", new StringContent(JsonSerializer.Serialize(createEnrollment), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode ? 1 : -1;
        }

        public async Task<List<EnrollmentViewModel>> GetListEnrollment()
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Enrollment/getListEnrollment").Result.Content.ReadFromJsonAsync<List<EnrollmentViewModel>>();
        }

        public async Task<List<RevenueViewModel>> GetMonthlyRevenueByInstructorId(int revenueSharePercentage, int instructorId, int year)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Enrollment/getMonthlyRevenueByInstructorId/{revenueSharePercentage}/{instructorId}/{year}").Result.Content.ReadFromJsonAsync<List<RevenueViewModel>>();


        }
        public async Task<List<RevenueViewModel>> GetMonthlyRevenueBySoldCourses(int revenueSharePercentage, int year)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Enrollment/getMonthlyRevenueBySoldedCourses/{revenueSharePercentage}/{year}").Result.Content.ReadFromJsonAsync<List<RevenueViewModel>>();


        }
    }
}
