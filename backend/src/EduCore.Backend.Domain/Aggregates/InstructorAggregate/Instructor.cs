using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.InstructorAggregate
{
    public class Instructor : AuditableEntity<Instructor>
    {
        public int UserProfileId { get; set; }
        public string? Qualifications { get; set; }
        public string Specializations { get; set; } = null!;
        public string? Website { get; set; }
        public int YearsOfExperience { get; set; }

        public virtual UserProfile UserProfile { get; set; } = null!;
        //public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
