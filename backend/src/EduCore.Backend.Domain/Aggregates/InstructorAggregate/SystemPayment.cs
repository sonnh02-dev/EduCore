using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;

using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.InstructorAggregate
{
    public class SystemPayment : Payment
    {
        public int InstructorProfileId { get; set; }
        //public decimal? PlatformFee { get; set; }
        //public decimal? InstructorRevenue { get; set; }
        //public virtual User Admin { get; set; } = null!;
        public virtual UserProfile InstructorProfile { get; set; } = null!;
        //public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }

}
