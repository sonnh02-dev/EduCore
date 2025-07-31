using EduCore.BackEnd.Domain.Aggregates.ExerciseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class SubmissionConfiguration : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {
            builder.ToTable("Submissions",Schemas.Exercise);

            builder.HasKey(sub => sub.Id).HasName("PK_Submissions_Id");

            builder.HasIndex(sub => new { sub.ExerciseId, sub.StudentProfileId }, "IX_Submissions_ExerciseId_StudentProfileId");

            builder.Property(sub => sub.Score)
                   .IsRequired();

            builder.Property(sub => sub.SubmittedAt)
                   .IsRequired();

            builder.HasOne(sub => sub.Exercise)
                   .WithMany(ex => ex.Submissions) 
                   .HasForeignKey(sub => sub.ExerciseId)
                   .HasConstraintName("FK_Submissions_Exercises_Id")
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(sub => sub.StudentProfile)
                   .WithMany(sp => sp.StudentSubmissions) 
                   .HasForeignKey(sub => sub.StudentProfileId)
                   .HasConstraintName("FK_Submissions_Profiles_AccountId")
                   .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
