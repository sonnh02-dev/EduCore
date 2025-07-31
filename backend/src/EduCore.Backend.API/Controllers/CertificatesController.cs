using EduCore.BackEnd.Application.Module.Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace EduCore.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
      public   ICertificateService _certificateService;

        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }
        //[HttpGet("getListCertificate")]
        //[EnableQuery]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _certificateService.GetListCertificate());
        //}
    }
}
