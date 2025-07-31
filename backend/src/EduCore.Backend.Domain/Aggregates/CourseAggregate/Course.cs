using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Domain.Aggregates.CertificateAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.ValueObjects;
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using EduCore.BackEnd.Domain.Aggregates.InstructorAggregate;
using EduCore.BackEnd.Domain.Aggregates.SaleAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.Domain.Common.Enumerations;
using EduCore.BackEnd.Domain.Common.ValueObjects;
using EduCore.BackEnd.SharedKernel;
using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate
{
    public partial class Course : AuditableAggregateRoot<Course>
    {
        public required string Title { get; set; }
        public int InstructorId { get; set; }
        public required string Description { get; set; }
        public required Level Level { get; set; }
        public required string Duration { get; set; }
        public bool IsPublished { get; private set; }

        public Pricing Pricing { get; private set; } = null!;
        public AggregateRating Rating { get; private set; } = null!;

        public int? SubCategoryId { get; set; }
        public ImageUrl ImageUrl { get; set; }
        public virtual ICollection<Sale>? Sales { get; set; }

        public Pricing GetCurrentPricing()
        {
            var now = DateTime.UtcNow;
            var currentSale = Sales?.FirstOrDefault(s => s.StartDate <= now && s.EndDate >= now);
            Result<Pricing> result = ValueObjects.Pricing.Create(Price, currentSale?.DiscountPercent);

            return new CoursePricing(Price, currentSale?.DiscountPercent);
        }
        public virtual Instructor Instructor { get; set; } = null!;
        public virtual SubCategory? SubCategory { get; set; } = null!;
        public virtual Certificate Certificate { get; set; } = null!;
        public virtual ICollection<Section> Sections { get; set; } = null!;
        public virtual ICollection<StudentPayment>? StudentPayments { get; set; }
        public virtual ICollection<Enrollment>? Enrollments { get; set; } = new HashSet<Enrollment>();
        public virtual ICollection<StudentCourse>? StudentCourses { get; set; }

        public virtual ICollection<SystemPayment>? SystemCheckouts { get; set; }
    }
}
