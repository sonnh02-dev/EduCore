using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {

        builder.Property(a => a.SubmissionInstruction)
              .HasMaxLength(1000);

        builder.Property(a => a.AllowResubmission)
              .IsRequired();

        builder.HasData(
             new Assignment
             {
                 Id = 2,
                 LectureId = 1,
                 Description = "Submit an HTML page",
                 MaxScore = 20,
                 WeightPercentage = 40,
                 SubmissionInstruction = "Submit via portal",
                 AllowResubmission = true,
                 DueDate = new DateTime(2024, 7, 22),
                 Discriminator = "Assignment"
             },
             new Assignment
             {
                 Id = 5,
                 LectureId = 2,
                 Description = "Write HTML for a contact form",
                 MaxScore = 20,
                 WeightPercentage = 70,
                 SubmissionInstruction = "Upload as .html file",
                 AllowResubmission = false,
                 DueDate = new DateTime(2024, 7, 27),
                 Discriminator = "Assignment"
             },
             new Assignment
             {
                 Id = 8,
                 LectureId = 4,
                 Description = "Box Model Layout Exercise",
                 MaxScore = 15,
                 WeightPercentage = 50,
                 SubmissionInstruction = "Provide a CSS file",
                 AllowResubmission = true,
                 DueDate = new DateTime(2024, 7, 30),
                 Discriminator = "Assignment"
             }
         );

    }
}
