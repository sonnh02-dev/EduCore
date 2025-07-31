using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Enrollments.DTOs
{
    public class UpdateEnrollmentStatusRequest
    {
        public int Id { get; set; }
        public EnrollmentStatus Status { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
