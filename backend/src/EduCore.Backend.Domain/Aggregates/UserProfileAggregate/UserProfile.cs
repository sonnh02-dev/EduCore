using System;
using System.Collections.Generic;
using System.Diagnostics;
using EduCore.BackEnd.Domain.Common;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;

using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
using EduCore.BackEnd.Domain.Aggregates.InstructorAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;
using EduCore.BackEnd.Domain.Common.ValueObjects;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate.ValueObjects;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate
{
    public  class UserProfile
    {
        public Id<UserProfile> UserAccountId { get; set; } = null!;
        public FullName FullName { get; set; }=null!;
        public Address? Address { get; set; }
        public Description Description { get; set; } = null!;
        public ImageUrl? ImageUrl { get; set; }

        public virtual ICollection<Setting> Settings { get; set; } = null!;
        public virtual ICollection<Comment>? Comments { get; set; }
       
        public virtual ICollection<Submission>? StudentSubmissions { get; set; }
        public virtual ICollection<SystemPayment>? SystemCheckouts { get; set; } 
        public virtual ICollection<Course> InstructorCourses { get; set; } = new HashSet<Course>();

        public virtual Student Student { get; set; } = null!;
        public virtual Instructor Instructor { get; set; } = null!;
        
    }
}
