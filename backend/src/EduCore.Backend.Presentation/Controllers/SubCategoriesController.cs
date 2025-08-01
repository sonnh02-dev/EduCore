using EduCore.BackEnd.Application.Modules.SubCategories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCore.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController : ControllerBase
    {
        public ISubCategoryService SubCategoryService { get; set; }
        public SubCategoriesController(ISubCategoryService subCategoryService) 
        {
            this.SubCategoryService = subCategoryService;
        }
        [HttpGet("/SubCategories")]
        public async Task<IActionResult> Get()
        {
            var subCategories = await SubCategoryService.GetAllSubCategory();
            return Ok(subCategories);
        }
    }
}
