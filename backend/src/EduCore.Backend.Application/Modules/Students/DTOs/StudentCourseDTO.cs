using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Students.DTOs
{
    public class StudentCourseDTO
    {
        public int StudentProfileId { get; set; }
        public int CourseId { get; set; }
        public int Status { get; set; }

    }
}