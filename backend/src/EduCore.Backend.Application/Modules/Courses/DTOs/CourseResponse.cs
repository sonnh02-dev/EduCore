using EduCore.BackEnd.Application.Modules.SubCategories;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EduCore.BackEnd.Application.Module.Courses.DTOs
{
    public class CourseResponse
    {
        [Key]
        [JsonPropertyOrder(0)]
        public int CourseId { get; set; }

        [JsonPropertyOrder(1)]
        public string Title { get; set; }

        [JsonPropertyOrder(4)]
        public SubCategoryResponse SubCategory { get; set; } = null;

        [JsonPropertyOrder(5)]
        public string Level { get; set; }

        [JsonPropertyOrder(6)]
        public int NumberOfSections { get; set; }

        [JsonPropertyOrder(7)]
        public int NumberOfLectures { get; set; }

        [JsonPropertyOrder(8)]
        public string Duration { get; set; } = null;

        //[JsonPropertyOrder(9)]
        //public int? InstructorId { get; set; }

        //[JsonPropertyOrder(10)]
        //public string? InstructorName { get; set; }

        [JsonPropertyOrder(11)]
        public decimal? Rating { get; set; }

        [JsonPropertyOrder(12)]
        public int? NumberOfRatings { get; set; }

        [JsonPropertyOrder(13)]
        public decimal? PriceAfterSale { get; set; }

        [JsonPropertyOrder(14)]
        public decimal? Price { get; set; }

        [JsonPropertyOrder(15)]
        public int? Sale { get; set; }

        [JsonPropertyOrder(16)]
        public int? NumberOfStudents { get; set; }

        [JsonPropertyOrder(17)]
        public string? Url { get; set; }


        [JsonPropertyOrder(18)]
        public DateTime? CreateTime { get; set; }   
        
        [JsonPropertyOrder(19)]
        public bool IsCompleted { get; set; }

        




    }
}
