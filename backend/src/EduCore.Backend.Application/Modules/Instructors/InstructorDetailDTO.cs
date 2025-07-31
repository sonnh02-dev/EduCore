using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using EduCore.BackEnd.Application.Module.Courses.DTOs;
using EduCore.BackEnd.Application.Modules.Reviews;

namespace EduCore.BackEnd.Application.Modules.Instructors
{
    public  class InstructorDetailDTO: InstructorDTO
    {
        [JsonPropertyOrder(14)]
        public  List<CourseResponse> Courses {  get; set; }

        [JsonPropertyOrder(15)]
        public List<ReviewDTO> Reviews { get; set; }
    }
}
