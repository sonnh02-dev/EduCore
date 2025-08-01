using EduCore.BackEnd.Domain.Aggregates.StudentCourseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.ToTable("StudentCourses", Schemas.Enrollment);
            builder.HasKey(sc => new { sc.StudentProfileId, sc.CourseId })
                   .HasName("PK_StudentCourses_StudentProfileId_CourseId");

            builder.HasIndex(sc => sc.StudentProfileId, "IX_StudentCourses_StudentProfileId");
            builder.HasIndex(sc => sc.CourseId, "IX_StudentCourses_CourseId");

            builder.HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_StudentCourses_Courses_Id");

            builder.HasOne(sc => sc.StudentProfile)
                .WithMany(sp => sp.StudentCourses)
                .HasForeignKey(sc => sc.StudentProfileId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentCourses_UserProfiles_UserId");
        }
    }
}
