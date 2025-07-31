using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EduCore.Web.Pages.Teacher
{
    public class CourseListModel : PageModel
    {
        private readonly ICourseService courseService;

        public CourseListModel(ICourseService courseService)
        {
            this.courseService = courseService;
        }
          //List<CourseViewModel > Courses { get; set; }    
        public async Task<IActionResult> OnGet()
        {
            //string userJson = HttpContextAccessor.HttpContext.Request.Cookies["User"] ??
            //      HttpContextAccessor.HttpContext?.Session?.GetString("User");
            //Courses = courseService.GetListCourseByInstructorId();
            return Page();  
        }
    }
}
