using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentCourseAggregate;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.StudentAggregate
{
    public class Student : AuditableAggregateRoot<Student>
    {
        public int UserProfileId { get; set; }
        public string? Level { get; set; }
        public string? Interests { get; set; }
        public virtual UserProfile UserProfile { get; set; } = null!;
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
        public virtual ICollection<StudentCourse>? StudentCourses { get; set; }
        public virtual ICollection<StudentPayment>? StudentCheckouts { get; set; }
    }
}
