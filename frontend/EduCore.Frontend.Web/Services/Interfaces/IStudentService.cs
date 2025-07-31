using EduCore.Frontend.Web.ViewModels;

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IStudentService
    {
        public Task<int> GetNumberStudents();
        //public Task<List<StudentDTO>> GetListStudent();
        //Task<int> UpdateStudentCourse(UpdateStudentCourseViewModel studentCourse);

    }
}

