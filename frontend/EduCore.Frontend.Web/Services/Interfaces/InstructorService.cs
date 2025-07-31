using EduCore.Frontend.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Collections;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public class InstructorService : IInstructorService

    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public InstructorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<InstructorViewModel>> GetListInstructorByFilter(int? cateId, int? subCateId, int? rating = null, string? status = null)
        {
            var cateFilter = subCateId.HasValue
        ? $"subCategoryDetails/any(s: s/subCategoryId eq {subCateId}) and"
        : cateId.HasValue ? $"subCategoryDetails/any(s: s/categoryId eq {cateId}) and" 
        : "";

            var ratingFilter = rating == null ? "rating ge 1 and rating le 5" : $"rating gt {rating - 1} and rating le {rating}";
            var statusFilter = status == null
                ? "isActive eq true or isActive eq false"
                : $"isActive eq {(status.Equals("active", StringComparison.OrdinalIgnoreCase) ? "true" : "false")}";
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Instructor/getListInstructor?$filter={cateFilter}  {ratingFilter} and {statusFilter} ").Result.Content.ReadFromJsonAsync<List<InstructorViewModel>>();


        }
        public async Task<InstructorDetailViewModel> GetInstructorDetailById(int id)
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Instructor/getInstructorDetailById/{id}").Result.Content.ReadFromJsonAsync<InstructorDetailViewModel>();


        }

        public async Task<List<InstructorViewModel>> GetListInstructor(string searchInfo = null)

        {

            var searchRoute = !string.IsNullOrEmpty(searchInfo) ?
                            $"?$filter=userId eq {(int.TryParse(searchInfo, out int result) ? result.ToString() : "null")} or " +
                            $"contains(fullName, '{searchInfo}') or " +
                            $"contains(email, '{searchInfo}') or " +
                            $"contains(phone, '{searchInfo}')"
     : "";

            var response =await  _httpClient.GetAsync($"{_baseAPIRoute}/Instructor/getListInstructor{searchRoute}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<InstructorViewModel>>();

            }
            return null;
        }

        public async Task<int> GetNumberInstructors()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/User/$count?$filter=roleId eq 2").Result.Content.ReadFromJsonAsync<int>();

        }
        public int GetNumberPageInstructor(int numberInstructor)
        {
            var numberPage = numberInstructor / 8;
            if (numberInstructor % 8 != 0)
            {
                numberPage += 1;
            }
            return numberPage;
        }

       
        //public async Task<List<InstructorViewModel>> SortInstructorList(string sortBy, List<InstructorViewModel> instructors)
        //{
        //    return sortBy switch
        //    {
        //        "rating" => instructors.OrderByDescending(i => i.Rating).ToList(),
        //        "monthRevenue" => instructors.OrderByDescending(i => i.CurrentMonthRevenue).ToList(),
        //        "studentEnroll" => instructors.OrderByDescending(i => i.NumberStudent).ToList(),
        //        "numberCourse" => instructors.OrderByDescending(i => i.NumberCourse).ToList(),
        //        _ => instructors 
        //    };
        //}


    }
}
