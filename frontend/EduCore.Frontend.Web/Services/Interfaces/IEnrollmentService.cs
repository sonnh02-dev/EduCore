using EduCore.Frontend.Web.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IEnrollmentService
    {
        public Task<int> AddEnrollment(AddEnrollmentViewModel createEnrollment);
        public Task<List<EnrollmentViewModel>> GetListEnrollment();
        public Task<List<RevenueViewModel>> GetMonthlyRevenueByInstructorId(int revenueSharePercentage,int instructorId, int year);
        public Task<List<RevenueViewModel>> GetMonthlyRevenueBySoldCourses(int revenueSharePercentage, int year);

    }
}
