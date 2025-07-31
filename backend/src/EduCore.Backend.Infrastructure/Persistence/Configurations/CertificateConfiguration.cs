using EduCore.BackEnd.Domain.Aggregates.CertificateAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("Certificates", Schemas.Certificate);

            builder.HasKey(cer => cer.CourseId)
                   .HasName("PK_Certificates_CourseId");

            builder.Property(cb => cb.CourseId)
               .HasConversion(
                   id => id.Value,
                   value => new Id<Certificate>(value)
               );

            builder.Ignore(cer=>cer.Id);

            builder.HasOne(cer => cer.Course)
                .WithOne(c => c.Certificate)
                .HasForeignKey<Certificate>(cer => cer.CourseId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Certificates_Courses_Id");

            builder.HasData(
                new Certificate { Id = 1, CourseId = 1, Title = "HTML & CSS Basics Certificate", Description = "Certificate for completing HTML & CSS Basics", CertificateUrl = "https://example.com/cert/html" },
                new Certificate { Id = 2, CourseId = 2, Title = "JavaScript Essentials Certificate", Description = "Certificate for mastering JavaScript core concepts", CertificateUrl = "https://example.com/cert/js" },
                new Certificate { Id = 3, CourseId = 3, Title = "React for Beginners Certificate", Description = "Certificate for learning React", CertificateUrl = "https://example.com/cert/react" },
                new Certificate { Id = 4, CourseId = 4, Title = "Advanced CSS Flexbox Certificate", Description = "Certificate for mastering CSS Flexbox", CertificateUrl = "https://example.com/cert/css-flex" },
                new Certificate { Id = 5, CourseId = 5, Title = "Node.js Fundamentals Certificate", Description = "Certificate for learning Node.js", CertificateUrl = "https://example.com/cert/node" },
                new Certificate { Id = 6, CourseId = 6, Title = "Fullstack MERN Project Certificate", Description = "Certificate for completing MERN stack project", CertificateUrl = "https://example.com/cert/mern" },
                new Certificate { Id = 7, CourseId = 7, Title = "Tailwind CSS Crash Course Certificate", Description = "Certificate for Tailwind CSS", CertificateUrl = "https://example.com/cert/tailwind" },
                new Certificate { Id = 8, CourseId = 8, Title = "JavaScript Algorithms Certificate", Description = "Certificate for completing JS algorithms", CertificateUrl = "https://example.com/cert/js-dsa" },
                new Certificate { Id = 9, CourseId = 9, Title = "Next.js from Scratch Certificate", Description = "Certificate for mastering Next.js", CertificateUrl = "https://example.com/cert/nextjs" },
                new Certificate { Id = 10, CourseId = 10, Title = "TypeScript for Web Dev Certificate", Description = "Certificate for learning TypeScript", CertificateUrl = "https://example.com/cert/ts" },
                new Certificate { Id = 11, CourseId = 11, Title = "Intro to Data Science Certificate", Description = "Certificate for learning Data Science basics", CertificateUrl = "https://example.com/cert/ds" },
                new Certificate { Id = 12, CourseId = 12, Title = "Python for Data Analysis Certificate", Description = "Certificate for pandas and numpy", CertificateUrl = "https://example.com/cert/python-data" },
                new Certificate { Id = 13, CourseId = 13, Title = "Android Development Certificate", Description = "Certificate for Android development", CertificateUrl = "https://example.com/cert/android" },
                new Certificate { Id = 14, CourseId = 14, Title = "iOS SwiftUI Basics Certificate", Description = "Certificate for iOS development", CertificateUrl = "https://example.com/cert/swiftui" },
                new Certificate { Id = 15, CourseId = 15, Title = "Unity Game Dev Certificate", Description = "Certificate for Unity game development", CertificateUrl = "https://example.com/cert/unity" },
                new Certificate { Id = 16, CourseId = 16, Title = "Unreal Engine Essentials Certificate", Description = "Certificate for Unreal Engine development", CertificateUrl = "https://example.com/cert/unreal" },
                new Certificate { Id = 17, CourseId = 17, Title = "C# for Beginners Certificate", Description = "Certificate for C# basics", CertificateUrl = "https://example.com/cert/csharp" },
                new Certificate { Id = 18, CourseId = 18, Title = "Java Programming Certificate", Description = "Certificate for Java programming", CertificateUrl = "https://example.com/cert/java" },
                new Certificate { Id = 19, CourseId = 19, Title = "PHP & MySQL Web App Certificate", Description = "Certificate for PHP web development", CertificateUrl = "https://example.com/cert/php" },
                new Certificate { Id = 20, CourseId = 20, Title = "Kotlin for Android Certificate", Description = "Certificate for Kotlin Android development", CertificateUrl = "https://example.com/cert/kotlin" }
            );

        }
    }
}
