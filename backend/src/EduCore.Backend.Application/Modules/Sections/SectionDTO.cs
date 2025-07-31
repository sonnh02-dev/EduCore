using EduCore.BackEnd.Application.Modules.Lectures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Sections
{
    public class SectionDTO
    {
        [Key]
        public int SectionId { get; set; }
        public string Title { get; set; }

        public int LectureNumber { get; set; }

        public string  Duration { get; set; }

        public bool IsCompleted { get; set; }

        public List<LectureResponse> Lectures { get; set; }
    }
}
