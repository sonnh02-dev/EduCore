using EduCore.BackEnd.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Enrollments.DTOs
{
    public class CreateEnrollmentRequest
    {
        [Key]
        //public int EnrollmentId { get; set; }

        public int StudentProfileId { get; set; }
        public int CourseId { get; set; }
        //public string Status { get; set; } = null!;
        //public DateTime? CompletedAt { get; set; }
    }
}
