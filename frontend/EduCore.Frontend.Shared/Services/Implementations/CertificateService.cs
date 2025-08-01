using EduCore.Frontend.Shared.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using System.Net.Http.Json;


namespace EduCore.Frontend.Shared.Services.Implementations
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
            return await _httpClient.GetFromJsonAsync<List<CertificateViewModel>>($"{_baseAPIRoute}/Certificate/getListCertificate");
        }
        public async Task<int> GetNumberCertificates()
        {
            return await _httpClient.GetAsync("https://localhost:7004/odata/Certificate/$count").Result.Content.ReadFromJsonAsync<int>();

        }
    }
}
