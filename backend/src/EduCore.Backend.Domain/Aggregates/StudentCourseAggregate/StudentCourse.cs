using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;

using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.StudentCourseAggregate
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public StudentCourseStatus Status { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }

}
