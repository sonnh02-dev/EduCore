
using EduCore.Frontend.Web.ViewModels;

using EduCore.Frontend.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;

namespace EduCore.Frontend.Web.Areas.Admin.Pages.Instructors
{
    public class DetailsModel : PageModel
    {
        public IInstructorService _instructorService;
        public ICourseService _courseService;
        public IEnrollmentService _enrollmentService;
        public IProfileService _userService;

        public DetailsModel(IInstructorService instructorService, ICourseService courseService, IEnrollmentService enrollment, IProfileService userService)
        {
            _instructorService = instructorService;
            _courseService = courseService;
            _enrollmentService = enrollment;
            _userService = userService;
        }
        //public List<RevenueViewModel>? MonthsRevenueOfPreviousYear { get; set; }
        //public List<RevenueViewModel>? MonthsRevenueOfCurrentYear { get; set; }
        public InstructorDetailViewModel Instructor { get; set; }
        ////public List<EnrollmentDetailDTO> EnrollmentList { get; set; }

        //[BindProperty]
        //public UserDTO? UpdatedUser { get; set; }=new UserDTO();

        //public async void OnGet(int instructorId = 4,int revenueSharePercentage=50)
        //{
        //    MonthsRevenueOfCurrentYear = await _enrollmentService.GetMonthlyRevenueByInstructorId(revenueSharePercentage, instructorId, DateTime.Now.Year);
        //    MonthsRevenueOfPreviousYear = await _enrollmentService.GetMonthlyRevenueByInstructorId(revenueSharePercentage, instructorId, DateTime.Now.Year - 1);
        //    Instructor = await _instructorService.GetInstructorDetailById(instructorId);
        //    EnrollmentList = _enrollmentService.GetListEnrollment().Result.Where(en => en.CourseInstructorId == instructorId).ToList();



        //}
        //public async Task<IActionResult> OnPost()
        //{

        //    if (_userService.UpdateUser(UpdatedUser).Result == 1)
        //    {
        //        TempData["Messenger"] = $"{UpdatedUser.FullName} with ID={UpdatedUser.UserId} update successfully!";
        //    }
        //    else
        //    {
        //        TempData["Messenger"] = "Update fail";
        //    }
        //    return RedirectToPage("./Detail", new { instructorId = UpdatedUser.UserId });
        //}
    }
}
