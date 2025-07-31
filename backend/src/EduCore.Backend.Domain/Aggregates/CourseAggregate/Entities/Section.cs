using System;
using System.Collections.Generic;

using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities
{
    public partial class Section : AggregateRoot<Section>
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public float WeightPercentage { get; set; }
        public int Position { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();

        //public virtual ICollection<CompletionStatus> CompletionStatuses { get; set; } = new List<CompletionStatus>();
    }
}
