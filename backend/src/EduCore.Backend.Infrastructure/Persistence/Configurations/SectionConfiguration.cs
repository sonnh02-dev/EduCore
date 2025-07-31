using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable("Sections", Schemas.Course);
            builder.HasKey(sec => sec.Id).HasName("PK_Sections_Id");
            builder.HasIndex(sec => sec.CourseId, "IX_Sections_CourseID");

            builder.Property(sec => sec.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.HasOne(sec => sec.Course)
                .WithMany(c => c.Sections)
                .HasForeignKey(sec => sec.CourseId)
                .HasConstraintName("FK_Sections_Courses_Id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
               // Course 1: HTML & CSS Basics
               new Section { Id = 1, CourseId = 1, Title = "Introduction to HTML", Duration = TimeSpan.FromMinutes(30), WeightPercentage = 30f, Position = 1 },
               new Section { Id = 2, CourseId = 1, Title = "Styling with CSS", Duration = TimeSpan.FromMinutes(60), WeightPercentage = 70f, Position = 2 },
               // Course 2: JavaScript Essentials
               new Section { Id = 3, CourseId = 2, Title = "JS Basics", Duration = TimeSpan.FromMinutes(45), WeightPercentage = 50f, Position = 1 },
               new Section { Id = 4, CourseId = 2, Title = "JS Functions", Duration = TimeSpan.FromMinutes(45), WeightPercentage = 50f, Position = 2 }
           );
        }
    }
}
