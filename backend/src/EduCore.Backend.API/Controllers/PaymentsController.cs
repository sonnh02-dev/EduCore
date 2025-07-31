using EduCore.BackEnd.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using EduCore.BackEnd.Application.Modules.Payments;

namespace EduCore.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        public ICheckoutService checkoutService { get; set; }
        public PaymentsController(ICheckoutService checkoutService)
        {
            this.checkoutService = checkoutService;
        }
        //[HttpGet("getListCheckout")]
        //[EnableQuery]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(checkoutService.GetCheckoutList());
        //}
        //[HttpPost("addCheckout")]
        //public async Task<IActionResult> AddCheckout([FromBody] CheckoutDTO checkout)
        //{
        //    checkoutService.AddCheckout(checkout);
        //    return Ok();
        //}
    }
}
