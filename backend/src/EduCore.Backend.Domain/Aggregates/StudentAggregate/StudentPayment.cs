
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.StudentAggregate
{
    public class StudentPayment : Payment
    {
        public int EnrollmentId { get; set; }
        public virtual Enrollment Enrollment { get; set; } = null!;
    }

}   
