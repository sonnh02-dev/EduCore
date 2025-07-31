using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;

using System;
using System.Collections.Generic;
using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.Domain.Aggregates.ReviewAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;

namespace EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate
{
    public partial class Enrollment : AuditableAggregateRoot<Enrollment>
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public EnrollmentStatus Status { get; set; } = EnrollmentStatus.Enrolled;
        public DateTime? CompletedAt { get; set; }
        //public virtual Course Course { get; set; } = null!;
        //public virtual Student Student { get; set; } = null!;
        public virtual StudentPayment Payment { get; set; } = null!;
        public virtual Review? Review { get; set; }
    }
}
