using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EduCore.Frontend.Web.Areas.Student.Pages.Cart
{
    public class AddModel : PageModel
    {
        private readonly ICourseService _courseService;

        public AddModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        //public async Task<IActionResult> OnGetAsync(int cId, int stdId)
        //{
        //    var sc = new StudentCourseViewModel { CourseId = cId, UserId = stdId, IsInCart = true };
        //    int result = await _courseService.AddStudentCourse(sc);

        //    if (result == 1)
        //    {
        //        ViewData["SuccessMessage"] = "Add the course to the cart success";
               
        //    }
        //    else
        //    {
        //        ViewData["ErrorMessage"] = "Failed to add the course to the cart.";
              
        //    }
        //    return Redirect("/Student");
        //}
    }
}
