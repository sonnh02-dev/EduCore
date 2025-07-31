using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;

namespace EduCore.Frontend.Web.Services.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public ReviewService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task< List<ReviewViewModel>> GetListReview()
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Review/GetListReview").Result.Content.ReadFromJsonAsync< List<ReviewViewModel>>();
        }
    }
}
