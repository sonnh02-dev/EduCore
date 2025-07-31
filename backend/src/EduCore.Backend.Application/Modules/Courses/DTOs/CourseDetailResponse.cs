using System.Text.Json.Serialization;

namespace EduCore.BackEnd.Application.Module.Courses.DTOs
{
    public class CourseDetailResponse : CourseResponse
    {

        [JsonPropertyOrder(20)]
        public string? Description { get; set; }
        public UserProfileResponse InstructorProfile { get; set; } = null!;

        //[JsonPropertyOrder(21)]
        //public List<SectionDTO>? Sections { get; set; }

        //[JsonPropertyOrder(22)]
        //public List<ReviewDTO>? Reviews { get; set; }

        //[JsonPropertyOrder(23)]
        //public List<DocumentDTO>? Documents { get; set; }


    }

}
