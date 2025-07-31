using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using System.Text;
using System.Text.Json;

namespace EduCore.Frontend.Web.Services.Implementations
{
    public class StudentService : IStudentService

    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

     

        //public Task<int> UpdateStudentCourse(UpdateStudentCourseViewModel studentCourse)
        //{
        //    var json = JsonSerializer.Serialize(studentCourse);
        //    var content = new StringContent(json, Encoding.UTF8, "application/json");
        //    var response = await _httpClient.PostAsync($"{_baseAPIRoute}/Course/addStudentCourse", content);

        //    return response.IsSuccessStatusCode ? 1 : -1;
        //}

        public async Task<int> GetNumberStudents()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/User/$count?$filter=roleId eq 1").Result.Content.ReadFromJsonAsync<int>();
        }
        //public async Task<List<StudentDTO>> GetListStudent()
        //{
        //    var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Student/getListStudent");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return await response.Content.ReadFromJsonAsync<List<StudentDTO>>();
        //    }
        //    return null;
        //}
    }
}
