using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions", Schemas.Exercise);
            builder.HasKey(ques => ques.Id).HasName("PK_Questions_Id");

            builder.HasIndex(ques => ques.QuizId, "IX_Questions_QuizId");

            builder.HasOne(ques => ques.Quiz)
              .WithMany(quiz => quiz.Questions)
              .HasForeignKey(ques => ques.QuizId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Question { Id = 1, QuizId = 1, Content = "What does HTML stand for?" },
                new Question { Id = 2, QuizId = 1, Content = "What tag is used for a paragraph?" },
                new Question { Id = 3, QuizId = 4, Content = "Which HTML tag creates a line break?" },
                new Question { Id = 4, QuizId = 4, Content = "Which tag makes text bold?" },
                new Question { Id = 5, QuizId = 7, Content = "What does the padding property affect in the box model?" },
                new Question { Id = 6, QuizId = 7, Content = "Which CSS property sets the border size?" }
            );
        }
    }
}
