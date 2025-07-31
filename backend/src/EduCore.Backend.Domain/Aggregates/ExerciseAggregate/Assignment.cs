using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public class Assignment : Exercise
    {
        public string? SubmissionInstruction { get; set; }
        public bool AllowResubmission { get; set; } = false;
    }

}
