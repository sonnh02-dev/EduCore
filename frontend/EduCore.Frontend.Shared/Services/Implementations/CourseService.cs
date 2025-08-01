using EduCore.Frontend.Shared.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace EduCore.Frontend.Shared.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public CourseViewModel CreateCourse(CourseViewModel course)
        {
            return null;
        }

        public async Task<CourseDetailViewModel> GetCourseDetailById(int courseId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/{courseId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CourseDetailViewModel>();
        }

        public async Task<List<CourseViewModel>> GetListCourseByInstructorId(int instructorId)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getListCourseByInstructorId/{instructorId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CourseViewModel>>();
        }



        //public async Task<List<CourseDetailDTO>> GetListCoursesByCategoryId(int cateId)
        //{

        //    var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getListCourseByCategoryId/{cateId}");
        //    response.EnsureSuccessStatusCode();

        //    return await response.Content.ReadFromJsonAsync<List<CourseDetailDTO>>();
        //}

        public async Task<int> GetNumberCourses(string filter = "true")
        {
            return await _httpClient.GetAsync($"https://localhost:7004/odata/Course/$count?$filter={filter}").Result.Content.ReadFromJsonAsync<int>();

        }


        public async Task<List<CourseViewModel>> GetListCoursesBySubCategoryId(int? subCateId)
        {

            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getListCourse?$filter=subCategoryId eq {subCateId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<CourseViewModel>>();
        }

        //public async Task<List<CourseViewModel>> GetListRelatedCourseBySubcates(List<SubCategoryDetailDTO> subCategories)
        //{
        //    var allCourses = new List<CourseViewModel>();

        //    foreach (var sub in subCategories)
        //    {
        //        var courses = await GetListCoursesBySubCategoryId(sub.SubCategoryId);
        //        if (courses != null)
        //        {
        //            allCourses.AddRange(courses);
        //        }
        //    }

        //    return allCourses;
        //}



        public int GetTotalPageCourse(int numberCourse, int pageSize)
        {
            var totalPage = numberCourse / pageSize;
            if (numberCourse % pageSize != 0)
            {
                totalPage += 1;
            }
            return totalPage;
        }

        public async Task<List<CourseViewModel>> GetTopSellingCourses()
        {
            var res = _httpClient.GetAsync($"{_baseAPIRoute}/Courses/GetTopSellingCourses").Result;
            return await res.Content.ReadFromJsonAsync<List<CourseViewModel>>();
        }
        public async Task<List<CourseViewModel>> GetTopSellingCoursesByCateId(int? cateId)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/GetTopSellingCoursesByCateId/{cateId}").Result.Content.ReadFromJsonAsync<List<CourseViewModel>>();
        }
        public async Task<List<CourseViewModel>> GetTopSellingCoursesBySubCateId(int? subCateId)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/GetTopSellingCoursesBySubCateId/{subCateId}").Result.Content.ReadFromJsonAsync<List<CourseViewModel>>();
        }


        public async Task<List<CourseViewModel>> GetListCourseByStudentId(int stId, bool isInCart)
        {
            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getListCourseByStudentId/{stId}/{isInCart}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<CourseViewModel>>();
        }
       

        public async Task<List<CourseViewModel>> GetListCourseByFilter(int cateId, int? subCateId, string? levels, int? rating, string? price, string sortBy)
        {
            levels = levels.Equals("All") ? "[\"Beginner\",\"Intermediate\",\"Advanced\"]" : levels;
            var filterSubCateId = subCateId != null ? $"and subCategoryId eq {subCateId}" : "";
            var orderProp = sortBy.Equals("Popular") ? "studentNumber desc"
                : sortBy.Equals("Rating") ? "rating desc"
                : "createTime desc";

            var filterPrice = price == null ? "ge 0"
                            : price.Equals("Paid") ? "gt 0"
                            : "eq 0";


            string filterRating = rating == null ? $"rating ge 0 and rating le 5"
                              : $"rating gt {rating - 1} and rating le {rating}";

            var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getListCourse?$filter=categoryId eq {cateId} {filterSubCateId}  and {filterRating} and contains({levels},level) and price {filterPrice}&$orderby={orderProp} ");
            return await response.Content.ReadFromJsonAsync<List<CourseViewModel>>();

        }
        public List<CourseViewModel> GetListCourseByPagging(List<CourseViewModel> courses, int pageIndex = 1, int pageSize = 8)
        {
            return courses.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task DownloadFilesAsync(List<string> fileUrls, string saveDirectory)
        {
            foreach (var fileUrl in fileUrls)
            {
                await DownloadFileAsync(fileUrl, saveDirectory);
            }
        }

        public async Task DownloadFileAsync(string fileUrl, string saveDirectory)
        {
            try
            {
                string fileName = Path.GetFileName(new Uri(fileUrl).LocalPath);
                string savePath = Path.Combine(saveDirectory, fileName);

                var response = await _httpClient.GetAsync(fileUrl);
                response.EnsureSuccessStatusCode();

                using (var fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await response.Content.CopyToAsync(fileStream);
                }

                Console.WriteLine($"File '{fileName}' downloaded and saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file '{fileUrl}': {ex.Message}");
            }
        }

        public Task<List<CourseViewModel>> GetEnrolledCourseListByStudentId(int stdId)
        {
            return _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getEnrolledCourseListByStudentId/{stdId}").Result.Content.ReadFromJsonAsync<List<CourseViewModel>>();    
        }

        //public async Task<CourseDetailDTO> GetStatusCourseDetailByStudentIdAndCourseId(int courseId, int stdId)
        //{
        //    var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Courses/getStatusCourseDetailByStudentIdAndCourseId/{courseId}/{stdId}");
        //    response.EnsureSuccessStatusCode();
        //    return await response.Content.ReadFromJsonAsync<CourseDetailDTO>();
        //}
    }
    }


