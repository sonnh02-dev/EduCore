using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Courses.DTOs
{
    public class UserProfileResponse
    {
        public int UserId {  get; set; }
        public string? FullName { get; set; }
        public string? ImageUrl { get; set; }

    }
}
