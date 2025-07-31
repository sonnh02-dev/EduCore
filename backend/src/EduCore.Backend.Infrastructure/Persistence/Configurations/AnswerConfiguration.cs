using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
using EduCore.BackEnd.Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answers", Schemas.Exercise);

            builder.HasKey(e => e.Id).HasName("PK_Answers_Id");

            builder.Property(cb => cb.Id)
               .HasConversion(
                   id => id.Value,
                   value => new Id<Answer>(value)
               );

            builder.HasIndex(e => e.QuestionId, "IX_Answers_QuestionId");

            builder.HasOne(e => e.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(e => e.QuestionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Answers_Questions_Id");

            builder.HasData(
                new Answer { Id = 1, QuestionId = 1, Content = "HyperText Markup Language", IsCorrect = true },
                new Answer { Id = 2, QuestionId = 1, Content = "Home Tool Markup Language", IsCorrect = false },
                new Answer { Id = 3, QuestionId = 1, Content = "Hyperlink and Text Markup Language", IsCorrect = false },
                new Answer { Id = 4, QuestionId = 1, Content = "HighText Machine Language", IsCorrect = false },

                new Answer { Id = 5, QuestionId = 2, Content = "<p>", IsCorrect = true },
                new Answer { Id = 6, QuestionId = 2, Content = "<div>", IsCorrect = false },
                new Answer { Id = 7, QuestionId = 2, Content = "<span>", IsCorrect = false },
                new Answer { Id = 8, QuestionId = 2, Content = "<h1>", IsCorrect = false },

                new Answer { Id = 9, QuestionId = 3, Content = "<br>", IsCorrect = true },
                new Answer { Id = 10, QuestionId = 3, Content = "<hr>", IsCorrect = false },
                new Answer { Id = 11, QuestionId = 3, Content = "<div>", IsCorrect = false },
                new Answer { Id = 12, QuestionId = 3, Content = "<h2>", IsCorrect = false },

                new Answer { Id = 13, QuestionId = 4, Content = "<b>", IsCorrect = true },
                new Answer { Id = 14, QuestionId = 4, Content = "<i>", IsCorrect = false },
                new Answer { Id = 15, QuestionId = 4, Content = "<u>", IsCorrect = false },
                new Answer { Id = 16, QuestionId = 4, Content = "<em>", IsCorrect = false },

                new Answer { Id = 17, QuestionId = 5, Content = "Inner spacing inside the border", IsCorrect = true },
                new Answer { Id = 18, QuestionId = 5, Content = "Space outside the element", IsCorrect = false },
                new Answer { Id = 19, QuestionId = 5, Content = "Text decoration", IsCorrect = false },
                new Answer { Id = 20, QuestionId = 5, Content = "Font styling", IsCorrect = false },

                new Answer { Id = 21, QuestionId = 6, Content = "border-width", IsCorrect = true },
                new Answer { Id = 22, QuestionId = 6, Content = "margin", IsCorrect = false },
                new Answer { Id = 23, QuestionId = 6, Content = "padding", IsCorrect = false },
                new Answer { Id = 24, QuestionId = 6, Content = "outline", IsCorrect = false }
            );
        }
    }
}
