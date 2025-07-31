// File: Configurations/CourseConfiguration.cs
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses", Schemas.Course);

            builder.Ignore(c => c.CreatorId);

            builder.HasKey(c => c.Id).HasName("PK_Courses_Id");

            builder.Property(cb => cb.Id)
                .HasConversion(
                    id => id.Value,
                    value => new Id<Course>(value)
                );

            builder.HasIndex(c => c.SubCategoryId, "IX_Courses_SubCategoryId");
            builder.HasIndex(c => new { c.InstructorId, c.SubCategoryId }, "IX_Courses_InstructorId_SubCategoryId");

            builder.Property(c => c.CreatedAt).HasColumnType("datetime2");

            builder.Property(c => c.Description).HasColumnType("text");

            builder.Property(c => c.RowVersion).IsRowVersion().IsConcurrencyToken();

            builder.Property(c => c.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(c => c.Level)
              .HasConversion(
                  level => level.Name, 
                  name => Level.Create(name).Value 
                 );

            builder.Property(c => c.Price).HasColumnType("decimal(10, 2)");

            builder.Property(c => c.Rating).HasColumnType("decimal(2, 1)");

            builder.Property(c => c.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(c => c.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            builder.HasOne(c => c.InstructorProfile)
                .WithMany(ip => ip.InstructorCourses)
                .HasForeignKey(c => c.InstructorProfileId)
                .HasConstraintName("FK_Courses_Profiles_AccountId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.SubCategory)
                      .WithMany(subCate => subCate.Courses)
                      .HasForeignKey(c => c.SubCategoryId)
                      .HasConstraintName("FK_Courses_SubCategories_Id")
                       .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
                 // 10 courses with SubCategoryId = 1
                 new Course { Id = 1, Title = "HTML & CSS Basics", InstructorProfileId = 2, Description = "Learn the fundamentals of web development", Level = "Beginner", Duration = "4h", Price = 49.99m, Rating = 4.5m, SubCategoryId = 1, Url = "https://example.com/html" },
                 new Course { Id = 2, Title = "JavaScript Essentials", InstructorProfileId = 2, Description = "Master JavaScript core concepts", Level = "Intermediate", Duration = "6h", Price = 59.99m, Rating = 4.6m, SubCategoryId = 1, Url = "https://example.com/js" },
                 new Course { Id = 3, Title = "React for Beginners", InstructorProfileId = 3, Description = "Build modern web apps with React", Level = "Beginner", Duration = "5h", Price = 69.99m, Rating = 4.7m, SubCategoryId = 1, Url = "https://example.com/react" },
                 new Course { Id = 4, Title = "Advanced CSS Flexbox", InstructorProfileId = 4, Description = "Create flexible layouts with CSS", Level = "Advanced", Duration = "3h", Price = 39.99m, Rating = 4.8m, SubCategoryId = 1, Url = "https://example.com/css-flex" },
                 new Course { Id = 5, Title = "Node.js Fundamentals", InstructorProfileId = 5, Description = "Backend JavaScript with Node.js", Level = "Intermediate", Duration = "5.5h", Price = 54.99m, Rating = 4.4m, SubCategoryId = 1, Url = "https://example.com/node" },
                 new Course { Id = 6, Title = "Fullstack Project: MERN", InstructorProfileId = 2, Description = "Build a complete MERN stack app", Level = "Advanced", Duration = "8h", Price = 89.99m, Rating = 4.9m, SubCategoryId = 1, Url = "https://example.com/mern" },
                 new Course { Id = 7, Title = "Tailwind CSS Crash Course", InstructorProfileId = 4, Description = "Style modern UI with Tailwind", Level = "Beginner", Duration = "2h", Price = 29.99m, Rating = 4.3m, SubCategoryId = 1, Url = "https://example.com/tailwind" },
                 new Course { Id = 8, Title = "JavaScript Algorithms", InstructorProfileId = 3, Description = "Master DSA in JS", Level = "Advanced", Duration = "6h", Price = 64.99m, Rating = 4.7m, SubCategoryId = 1, Url = "https://example.com/js-dsa" },
                 new Course { Id = 9, Title = "Next.js from Scratch", InstructorProfileId = 5, Description = "Learn SSR with Next.js", Level = "Intermediate", Duration = "5h", Price = 74.99m, Rating = 4.5m, SubCategoryId = 1, Url = "https://example.com/nextjs" },
                 new Course { Id = 10, Title = "TypeScript for Web Dev", InstructorProfileId = 2, Description = "Use TS to build reliable apps", Level = "Intermediate", Duration = "4.5h", Price = 59.99m, Rating = 4.6m, SubCategoryId = 1, Url = "https://example.com/ts" },

                 // 10 other courses with different SubCategoryIds
                 new Course { Id = 11, Title = "Intro to Data Science", InstructorProfileId = 2, Description = "Data science basics", Level = "Beginner", Duration = "3h", Price = 49.99m, Rating = 4.5m, SubCategoryId = 2, Url = "https://example.com/ds" },
                 new Course { Id = 12, Title = "Python for Data Analysis", InstructorProfileId = 2, Description = "Use pandas and numpy", Level = "Intermediate", Duration = "6h", Price = 59.99m, Rating = 4.6m, SubCategoryId = 2, Url = "https://example.com/python-data" },
                 new Course { Id = 13, Title = "Android Development", InstructorProfileId = 3, Description = "Build Android apps", Level = "Beginner", Duration = "5h", Price = 69.99m, Rating = 4.7m, SubCategoryId = 3, Url = "https://example.com/android" },
                 new Course { Id = 14, Title = "iOS SwiftUI Basics", InstructorProfileId = 4, Description = "Start with iOS dev", Level = "Beginner", Duration = "4h", Price = 79.99m, Rating = 4.6m, SubCategoryId = 3, Url = "https://example.com/swiftui" },
                 new Course { Id = 15, Title = "Unity Game Dev", InstructorProfileId = 5, Description = "Create 2D games", Level = "Intermediate", Duration = "6h", Price = 84.99m, Rating = 4.5m, SubCategoryId = 4, Url = "https://example.com/unity" },
                 new Course { Id = 16, Title = "Unreal Engine Essentials", InstructorProfileId = 2, Description = "3D game dev with UE", Level = "Advanced", Duration = "7h", Price = 89.99m, Rating = 4.7m, SubCategoryId = 4, Url = "https://example.com/unreal" },
                 new Course { Id = 17, Title = "C# for Beginners", InstructorProfileId = 4, Description = "Learn C# basics", Level = "Beginner", Duration = "4h", Price = 44.99m, Rating = 4.4m, SubCategoryId = 5, Url = "https://example.com/csharp" },
                 new Course { Id = 18, Title = "Java Programming", InstructorProfileId = 3, Description = "Core Java concepts", Level = "Intermediate", Duration = "5h", Price = 54.99m, Rating = 4.6m, SubCategoryId = 5, Url = "https://example.com/java" },
                 new Course { Id = 19, Title = "PHP & MySQL Web App", InstructorProfileId = 5, Description = "Dynamic websites with PHP", Level = "Intermediate", Duration = "6h", Price = 59.99m, Rating = 4.3m, SubCategoryId = 3, Url = "https://example.com/php" },
                 new Course { Id = 20, Title = "Kotlin for Android", InstructorProfileId = 2, Description = "Modern Android dev", Level = "Intermediate", Duration = "5h", Price = 64.99m, Rating = 4.5m, SubCategoryId = 3, Url = "https://example.com/kotlin" }
             );
            ;
        }
    }
}
