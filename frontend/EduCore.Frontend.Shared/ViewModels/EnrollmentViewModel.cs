namespace EduCore.Frontend.Shared.ViewModels
{
    public class EnrollmentViewModel
    {
        public int EnrollmentId { get; set; }

        public int StudentProfileId { get; set; }
        public int CourseId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? CompletedAt { get; set; }
    }
}
