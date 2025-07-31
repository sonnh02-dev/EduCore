using EduCore.Frontend.Web.ViewModels;
using EduCore.Frontend.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace EduCore.Frontend.Web.Areas.Student.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        public ICourseService courseService;
        public ICategoryService categoryService;
        private IHostingEnvironment _environment;

        public IProfileService userService;


        public DetailsModel(ICourseService courseService, ICategoryService categoryService, IProfileService userService, IHostingEnvironment environment)
        {
            this.courseService = courseService;
            this.categoryService = categoryService;
            this.userService = userService;
            _environment = environment;
        }
        public List<CourseViewModel> RelatedCourses { get; set; }
        //public UserDTO Instructor { get; set; }



        //[BindProperty]
        //public CourseDetailDTO CourseDetail { get; set; }
        //public async Task OnGetAsync(int? cId)
        //{
        //    var userJson = HttpContext.Session.GetString("User");
        //    if (userJson != null)
        //    {
        //        var u = JsonConvert.DeserializeObject<UserDTO>(userJson);
        //        ViewData["NumberCourseCart"] = (await courseService.GetListCourseByStudentId(u.UserId, true)).Count();
        //    }
        //    if (cId != null)
        //    {
        //        TempData["CourseId"] = cId;
        //    }
        //    CourseDetail = await courseService.GetCourseDetailByCourseId(cId ?? (int)TempData.Peek("CourseId"));
        //    RelatedCourses = await courseService.GetListCoursesBySubCategoryId(CourseDetail.SubCategoryId);
        //    Instructor = await userService.GetUserById((CourseDetail.InstructorId));
        //}

        //public async Task<IActionResult> OnPostDownloadFile(List<string> fileUrls, string saveDirectory)
        //{
        //    if (fileUrls == null || fileUrls.Count == 0)
        //    {
        //        ModelState.AddModelError("", "No files selected for download.");
        //        return Page();
        //    }

        //    if (string.IsNullOrEmpty(saveDirectory))
        //    {
        //        saveDirectory = Path.Combine(_environment.ContentRootPath, "Downloads");
        //    }

        //    if (!Directory.Exists(saveDirectory))
        //    {
        //        Directory.CreateDirectory(saveDirectory);
        //    }

        //    await courseService.DownloadFilesAsync(fileUrls, saveDirectory);

        //    return RedirectToPage();
        //}

        // public async Task<IActionResult> OnGetCourseStatus(int cId,int stdId)
        //{
        //    CourseDetail = await courseService.GetStatusCourseDetailByStudentIdAndCourseId(cId,stdId);
        //    RelatedCourses = await courseService.GetListCoursesBySubCategoryId(CourseDetail.SubCategoryId);
        //    Instructor = await userService.GetUserById((CourseDetail.InstructorId));
        //    return Page();
        //}


    }
}
