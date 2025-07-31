using EduCore.BackEnd.Application.DTOs.Response;
using EduCore.BackEnd.Application.Modules.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Instructors
{
    public class InstructorDTO : UserDTO
    {
        [JsonPropertyOrder(9)]
        public decimal Rating { get; set; }

        [JsonPropertyOrder(10)]
        public int NumberStudent {  get; set; }

        [JsonPropertyOrder(11)]
        public int NumberCourse {  get; set; }

        [JsonPropertyOrder(12)]
        public List<SubCategoryDetailDTO > SubCategoryDetails {  get; set; }

        [JsonPropertyOrder(13)]
        public decimal? CurrentMonthRevenue {  get; set; }

    }
}
