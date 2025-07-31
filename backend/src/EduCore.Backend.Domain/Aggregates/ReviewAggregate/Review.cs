using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.ReviewAggregate
{
    public class Review : AuditableAggregateRoot<Review>
    {
        public int EnrollmentId { get; set; }
        public decimal Rating { get; set; }
        public string Content { get; set; } = null!;
        public int? ReOpen { get; set; }

        public Enrollment Enrollment { get; set; } = null!;

    }
}
