using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace EduCore.Frontend.Web.Areas.Student.Pages.Instructors
{
    public class DetailsModel : PageModel
    {
        //IInstructorService _instructorService;
        //ICourseService _courseService;
        //public ICategoryService categoryService;


        //public DetailModel(IInstructorService instructorService, ICourseService courseService, ICategoryService categoryService)
        //{
        //    _instructorService = instructorService;
        //    _courseService = courseService;
        //    this.categoryService = categoryService;
        //}
        //[BindProperty]
        //public InstructorDetailViewModel InstructorDetail { get; set; }

        //[BindProperty]
        //public List<CourseViewModel> RelatedCourses { get; set; }
        //public async Task<IActionResult> OnGetAsync(int insId)
        //{
        //    var userJson = HttpContext.Session.GetString("User");
        //    if (userJson != null)
        //    {
        //        var u = JsonConvert.DeserializeObject<UserDTO>(userJson);
        //        ViewData["NumberCourseCart"] = (await _courseService.GetListCourseByStudentId(u.UserId, true)).Count();
        //    }
        //    InstructorDetail = await _instructorService.GetInstructorDetailById(insId);
        //    RelatedCourses = await _courseService.GetListRelatedCourseBySubcates(InstructorDetail.SubCategoryDetails);
        //    ViewData["Categories"] = await categoryService.GetListCategory();

        //    return Page();
        //}
    }
}
