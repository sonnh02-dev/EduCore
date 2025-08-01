using EduCore.BackEnd.Domain.Common.Enumerations;

namespace EduCore.BackEnd.Domain.Aggregates.StudentAggregate
{
    public sealed class EnrollmentStatus : Enumeration<EnrollmentStatus>
    {
        public static readonly EnrollmentStatus Enrolled = new(0, "Enrolled");
        public static readonly EnrollmentStatus InProgress = new(1, "InProgress");
        public static readonly EnrollmentStatus Completed = new(2, "Completed");
        public static readonly EnrollmentStatus Cancelled = new(3, "Cancelled");
        public static readonly EnrollmentStatus Expired = new(4, "Expired");
        public static readonly EnrollmentStatus Failed = new(5, "Failed");

        private EnrollmentStatus(int value, string name) : base(value, name) { }

        public bool IsFinalStatus => this == Completed || this == Cancelled || this == Failed || this == Expired;
    }
}
