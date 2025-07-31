using AutoMapper;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(EduCoreDbContext dbContext) : base(dbContext) { }

        //public IQueryable<Course> GetListCourse()
        //{
        //    return _entitySet
        //        .Include(c => c.InstructorProfile)
        //        .Include(c => c.SubCategory).ThenInclude(subc => subc.Category)
        //        .Include(c => c.Sections).ThenInclude(s => s.Lectures)
        //        .Include(c => c.Reviews).ThenInclude(r => r.Student)
        //        .Include(c => c.Enrollments).ThenInclude(e => e.Student).ThenInclude(u => u.Role)
        //        .Include(c => c.Documents)
        //        .AsSplitQuery().AsNoTracking(); 
        //}

        //public IQueryable<Course> GetTopSellingCourses()
        //{
        //    return GetListCourse()
        //        .OrderByDescending(c => c.Checkouts.Count)
        //        .Take(8);
        //}

        //public IQueryable<Course> GetTopSellingCoursesByCateId(int cateId)
        //{
        //    return GetListCourse()
        //        .Where(c => c.SubCategory.CategoryId == cateId)
        //        .OrderByDescending(c => c.Checkouts.Count)
        //        .Take(8);
        //}

        //public IQueryable<Course> GetTopSellingCoursesBySubCateId(int subCateId)
        //{
        //    return GetListCourse()
        //        .Where(c => c.SubCategoryId == subCateId)
        //        .OrderByDescending(c => c.Checkouts.Count)
        //        .Take(8);
        //}

        //public IQueryable<Course> GetEnrolledCourseListByStudentId(int stdId)
        //{
        //    return GetListCourse()
        //        .Where(c => c.Enrollments.Any(e => e.StudentId == stdId));
        //}

        //public IQueryable<Course> GetListCourseByStudentId(int stdId, bool isInCart)
        //{
        //    return GetListCourse()
        //        .Where(c => c.StudentCourses.Any(sc =>
        //            sc.UserId == stdId &&
        //            sc.User.Role.RoleId == 1 &&
        //            sc.IsInCart == isInCart));
        //}

        //public async Task<bool> IsExistingCourse(int courseId)
        //{
        //    return await _entitySet.AnyAsync(c => c.CourseId == courseId);
        //}

        //public IQueryable<Course> GetListCourseByInstructorId(int instructorId)
        //{
        //    return GetListCourse().Where(c => c.InstructorId == instructorId);
        //}

        //public async Task<Course?> GetCourseDetailByCourseId(int courseId)
        //{
        //    return await GetListCourse()
        //        .FirstOrDefaultAsync(c => c.CourseId == courseId);
        //}
    }
}
