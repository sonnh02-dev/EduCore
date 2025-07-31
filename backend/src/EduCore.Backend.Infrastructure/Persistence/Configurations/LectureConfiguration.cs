using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class LectureConfiguration : IEntityTypeConfiguration<Lecture>
    {
        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            builder.ToTable("Lectures", Schemas.Course);
            builder.HasKey(lec => lec.Id).HasName("PK_Lectures_Id");

            builder.HasIndex(lec => lec.SectionId, "IX_Lectures_SectionId");

            builder.Property(lec => lec.Title).HasMaxLength(255);

            

            builder.HasOne(lec => lec.Section)
                .WithMany(sec => sec.Lectures)
                .HasForeignKey(lec => lec.SectionId)
                .HasConstraintName("FK_Lectures_Sections_Id")
                 .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
               new Lecture { Id = 1, SectionId = 1, Title = "What is HTML?", Duration = TimeSpan.FromMinutes(15), ViewCount = 200, Position = 1, WeightPercentage = 50f, IsPreview = true },
               new Lecture { Id = 2, SectionId = 1, Title = "Basic Tags", Duration = TimeSpan.FromMinutes(15), ViewCount = 150, Position = 2, WeightPercentage = 50f },

               new Lecture { Id = 3, SectionId = 2, Title = "CSS Selectors", Duration = TimeSpan.FromMinutes(30), ViewCount = 180, Position = 1, WeightPercentage = 50f },
               new Lecture { Id = 4, SectionId = 2, Title = "CSS Box Model", Duration = TimeSpan.FromMinutes(30), ViewCount = 160, Position = 2, WeightPercentage = 50f },

               new Lecture { Id = 5, SectionId = 3, Title = "Variables and Data Types", Duration = TimeSpan.FromMinutes(22), ViewCount = 210, Position = 1, WeightPercentage = 50f },
               new Lecture { Id = 6, SectionId = 3, Title = "Control Flow", Duration = TimeSpan.FromMinutes(23), ViewCount = 190, Position = 2, WeightPercentage = 50f },

               new Lecture { Id = 7, SectionId = 4, Title = "Functions Basics", Duration = TimeSpan.FromMinutes(25), ViewCount = 170, Position = 1, WeightPercentage = 50f },
               new Lecture { Id = 8, SectionId = 4, Title = "Arrow Functions", Duration = TimeSpan.FromMinutes(20), ViewCount = 165, Position = 2, WeightPercentage = 50f }
           );
        }
    }
}
