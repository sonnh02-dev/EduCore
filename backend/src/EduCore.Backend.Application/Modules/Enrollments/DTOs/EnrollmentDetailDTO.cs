﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Enrollments.DTOs
{
    public class EnrollmentDetailDTO : CreateEnrollmentRequest
    {
        public EnrollmentDetailDTO()
        {
        }

        public string StudentName { get; set; }
        public string StudentImage { get; set; }
        public string CourseTitle { get; set; }
        public string CourseImage { get; set; }
        public decimal CoursePrice {  get; set; }
        public int CourseSale {  get; set; }
        public int  CourseInstructorId { get; set; }

    }
}

