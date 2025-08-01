using EduCore.Frontend.Shared.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;

namespace EduCore.Frontend.Shared.Services.Implementations
{
    public class CompletionStatusServicec : ICompletionStatusService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute;

        public CompletionStatusServicec(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseAPIRoute = "https://localhost:7004/api";
        }
        //public  async Task< List<CompletionStatusDTO>> GetCompletionStatusListByStudentId(int stdId)
        //{
        //   return await  _httpClient.GetAsync($"{_baseAPIRoute}/CompletionStatus/getAllCompletionStatus?$filter=UserId eq {stdId}").Result.Content.ReadFromJsonAsync<List<CompletionStatusDTO>>();
        //}
    }
}
