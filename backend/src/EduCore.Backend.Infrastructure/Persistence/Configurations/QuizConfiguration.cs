using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EduCore.BackEnd.Infrastructure.Persistence.Configurations;
using System.Reflection.Emit;
using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;

public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.HasData(
             new Quiz
             {
                 Id = 1,
                 LectureId = 1,
                 Description = "Quiz for HTML Basics",
                 MaxScore = 10,
                 WeightPercentage = 20,
                 Discriminator = "Quiz",
                 DueDate = new DateTime(2024, 7, 20)
             },
             new Quiz
             {
                 Id = 4,
                 LectureId = 2,
                 Description = "Quiz on Basic HTML Tags",
                 MaxScore = 10,
                 WeightPercentage = 30,
                 Discriminator = "Quiz",
                 DueDate = new DateTime(2024, 7, 25)
             },
             new Quiz
             {
                 Id = 7,
                 LectureId = 4,
                 Description = "Quiz on CSS Box Model",
                 MaxScore = 15,
                 WeightPercentage = 50,
                 Discriminator = "Quiz",
                 DueDate = new DateTime(2024, 7, 30)
             }
         );

    }
}
