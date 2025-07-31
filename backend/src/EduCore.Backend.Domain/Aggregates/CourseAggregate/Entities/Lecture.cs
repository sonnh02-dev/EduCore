using System;
using System.Collections.Generic;
using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;
using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities
{
    public partial class Lecture : AggregateRoot<Lecture>
    {
        public int SectionId { get; set; }
        public bool IsPreview { get; set; } = false;
        public string Title { get; set; } = null!;     
        public int ViewCount { get; set; }
        public string? ResourceUrl { get; set; }
        public TimeSpan Duration { get; set; }
        public float WeightPercentage { get; set; }
        public int Position { get; set; }
        public virtual Section Section { get; set; } = null!;
        //public virtual ICollection<Comment>? Comments { get; set; }
        //public virtual ICollection<Exercise>? Exercises { get; set; } = new List<Exercise>();
        public virtual ICollection<ContentBlock> ContentBlocks { get; set; } = new List<ContentBlock>();

    }
}
