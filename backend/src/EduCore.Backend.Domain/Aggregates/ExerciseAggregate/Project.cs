using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate
{
    public class Project : Exercise
    {
        public string? GuidelineDocumentUrl { get; set; }
        public string? SampleProjectUrl { get; set; }
    }

}
