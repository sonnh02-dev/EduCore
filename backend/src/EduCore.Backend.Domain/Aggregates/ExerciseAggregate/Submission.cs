using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public class Submission : Entity<Submission>
    {
        public int ExerciseId { get; set; }
        public int StudentProfileId { get; set; }
        public float? Score { get; set; }
        public string? Feedback { get; set; }
        public DateTime SubmittedAt { get; set; }
        public bool IsResubmitted { get; set; }      
        public DateTime? ResubmittedAt { get; set; }

        [NotMapped]
        public bool IsLate => SubmittedAt > Exercise.DueDate;

        [NotMapped]
        public bool IsResubmitLate => IsResubmitted && ResubmittedAt.HasValue && ResubmittedAt > Exercise.DueDate;


        public virtual Exercise Exercise { get; set; } = null!;
        public virtual UserProfile StudentProfile { get; set; } = null!;
    }
}
