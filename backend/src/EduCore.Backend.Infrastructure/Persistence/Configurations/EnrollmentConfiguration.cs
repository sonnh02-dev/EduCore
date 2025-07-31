using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)

        {
            builder.ToTable("Enrollments", Schemas.Enrollment);


            builder.HasKey(enr => enr.Id).HasName("PK_Enrollments_EnrollmentId");

            builder.HasIndex(enr => new { enr.StudentProfileId, enr.CourseId }, "IX_Enrollments_StudentProfileId_CourseId").IsUnique();
            builder.HasIndex(enr => enr.StudentProfileId, "IX_Enrollments_StudentProfileId");
            builder.HasIndex(enr => enr.CourseId, "IX_Enrollments_CourseId");

            builder.Property(e => e.Status)
              .HasConversion(
                  v => v.Value,
                  v => EnrollmentStatus.FromValue(v)!
              );


            builder.Property(enr => enr.CompletedAt).HasColumnType("datetime");

            //builder.Property(enr => enr.CreatedAt).HasDefaultValueSql("GETDATE()");


            builder.HasOne(enr => enr.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(enr => enr.CourseId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Enrollmens_Courses_Id");

            builder.HasOne(enr => enr.StudentProfile)
                .WithMany(sp => sp.StudentEnrollments)
                .HasForeignKey(enr => enr.StudentProfileId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Enrollmens_UserProfiles_UserId");

            builder.HasData(
               new Enrollment
               {
                   Id = 1,
                   StudentProfileId = 6,
                   CourseId = 1,
                   Status = EnrollmentStatus.Enrolled,
                   CompletedAt = null,
                   CreatorId = 6,
               },
               new Enrollment
               {
                   Id = 2,
                   StudentProfileId = 6,
                   CourseId = 3,
                   Status = EnrollmentStatus.Completed,
                   CompletedAt = new DateTime(2024, 7, 1),
                   CreatorId = 6,

               },
               new Enrollment
               {
                   Id = 3,
                   StudentProfileId = 6,
                   CourseId = 2,
                   Status = EnrollmentStatus.Failed,
                   CreatorId = 6,

               },
               new Enrollment
               {
                   Id = 4,
                   StudentProfileId = 6,
                   CourseId = 11,
                   Status = EnrollmentStatus.Enrolled,
                   CreatorId = 6,

               },
               new Enrollment
               {
                   Id = 5,
                   StudentProfileId = 7,
                   CourseId = 3,
                   Status = EnrollmentStatus.Completed,
                   CompletedAt = new DateTime(2024, 7, 10),
                   CreatorId = 7,


               }, new Enrollment
               {
                   Id = 6,
                   StudentProfileId = 8,
                   CourseId = 3,
                   Status = EnrollmentStatus.Completed,
                   CompletedAt = new DateTime(2024, 7, 5),
                   CreatorId = 8


               }, new Enrollment
               {
                   Id = 7,
                   StudentProfileId = 9,
                   CourseId = 3,
                   Status = EnrollmentStatus.Completed,
                   CompletedAt = new DateTime(2024, 7, 4),
                   CreatorId = 9

               },
               new Enrollment
               {
                   Id = 8,
                   StudentProfileId = 10,
                   CourseId = 18,
                   Status = EnrollmentStatus.Failed,
                   CreatorId = 10

               },
               new Enrollment
               {
                   Id = 9,
                   StudentProfileId = 10,
                   CourseId = 3,
                   Status = EnrollmentStatus.Completed,
                   CompletedAt = new DateTime(2024, 6, 15),
                   CreatorId = 10

               }
           );
        }
    }
}
