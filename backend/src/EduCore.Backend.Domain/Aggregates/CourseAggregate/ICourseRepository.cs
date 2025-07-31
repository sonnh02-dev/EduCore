using EduCore.BackEnd.Domain.Common.Repositories;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        //IQueryable<Course> GetListCourse();

        //IQueryable<Course> GetListCourseByInstructorId(int instructorId);
        //IQueryable<Course> GetListCourseByStudentId(int studentId, bool isInCart);
        //IQueryable<Course> GetTopSellingCourses();
        //IQueryable<Course> GetTopSellingCoursesByCateId(int cateId);
        //IQueryable<Course> GetTopSellingCoursesBySubCateId(int subCateId);
        //IQueryable<Course> GetEnrolledCourseListByStudentId(int studentId);

        //Task<Course?> GetCourseDetailByCourseId(int courseId);
        //Task<bool> IsExistingCourse(int courseId);
    }
}
