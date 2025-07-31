using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.Property(p => p.GuidelineDocumentUrl)
              .HasMaxLength(1000);

        builder.Property(p => p.SampleProjectUrl)
              .HasMaxLength(1000);

        builder.HasData(
               new Project
               {
                   Id = 3,
                   LectureId = 1,
                   Description = "Build a static website",
                   MaxScore = 30,
                   WeightPercentage = 40,
                   GuidelineDocumentUrl = "https://example.com/guideline.pdf",
                   SampleProjectUrl = "https://example.com/sample.zip",
                   Discriminator = "Project",
                   DueDate = new DateTime(2024, 7, 22),

               },
               new Project
               {
                   Id = 6,
                   LectureId = 3,
                   Description = "Style a webpage using selectors",
                   MaxScore = 30,
                   WeightPercentage = 100,
                   GuidelineDocumentUrl = "https://example.com/css_guideline.pdf",
                   SampleProjectUrl = "https://example.com/css_sample.zip",
                   Discriminator = "Project",
                   DueDate = new DateTime(2024, 7, 22),

               }
           );
    }
}
