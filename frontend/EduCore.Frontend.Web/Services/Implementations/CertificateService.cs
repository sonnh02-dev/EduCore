using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;


namespace EduCore.Frontend.Web.Services.Implementations
{
    public class CertificateService : ICertificateService

    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public CertificateService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<CertificateViewModel>> GetCertificates()
        {
            return await _httpClient.GetAsync($"{_baseAPIRoute}/Certificate/getListCertificate").Result.Content.ReadFromJsonAsync<List<CertificateViewModel>>();
        }
        public async Task<int> GetNumberCertificates()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/Certificate/$count").Result.Content.ReadFromJsonAsync<int>();

        }
    }
}
