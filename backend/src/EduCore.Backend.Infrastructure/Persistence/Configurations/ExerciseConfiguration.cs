using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercises", Schemas.Exercise);
            builder.HasKey(ex => ex.Id).HasName("PK_Exercises_Id");

            builder.HasIndex(ex => new { ex.LectureId, ex.Discriminator }, "IX_Exercises_LectureId_Discriminator");

            builder.Property(ex => ex.Description)
                  .IsRequired()
                  .HasMaxLength(1000);

            builder.Property(ex => ex.Discriminator)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(ex => ex.ExerciseUrl)
                  .HasMaxLength(500);

            builder.Property(ex => ex.MaxScore)
                  .HasDefaultValue(10);

            builder.Property(ex => ex.WeightPercentage)
                  .HasDefaultValue(0);


            builder.HasOne(ex => ex.Lecture)
                .WithMany(l => l.Exercises)
                .HasForeignKey(ex => ex.LectureId)
                .HasConstraintName("FK_Exercises_Lectures_Id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasDiscriminator<string>("Discriminator")
                 .HasValue<Quiz>("Quiz")
                 .HasValue<Assignment>("Assignment")
                 .HasValue<Project>("Project");
            
        }
    }
}
