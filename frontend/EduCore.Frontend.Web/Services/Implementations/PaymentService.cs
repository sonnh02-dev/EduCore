using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using System.Text;
using System.Text.Json;

namespace EduCore.Frontend.Web.Services.Implementations
{
    public class PaymentService : IPaymentService
    {

        private readonly HttpClient _httpClient;
        private readonly string _baseAPIRoute = "https://localhost:7004/api";

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }

        //public async Task<int> AddCheckout(CheckoutDTO newCheckout)
        //{
        //    var response = await _httpClient.PostAsync($"{_baseAPIRoute}/Checkout/addCheckout", new StringContent(JsonSerializer.Serialize(newCheckout), Encoding.UTF8, "application/json"));
        //    return response.IsSuccessStatusCode ? 1 : -1;
        //}

        //public async Task<CheckoutDTO> GetCheckoutById(int id)
        //{
        //    var response = await _httpClient.GetAsync($"{_baseAPIRoute}/Checkout/getListCheckout?$filter=checkoutId eq {id}");
        //    response.EnsureSuccessStatusCode();
        //    return await response.Content.ReadFromJsonAsync<CheckoutDTO>();

        //}


    }
}
