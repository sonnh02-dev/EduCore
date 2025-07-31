
using System;
using System.Collections.Generic;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.CertificateAggregate
{
    public partial class Certificate : AggregateRoot<Certificate>
    {
        public Id<Certificate> CourseId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CertificateUrl { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}
