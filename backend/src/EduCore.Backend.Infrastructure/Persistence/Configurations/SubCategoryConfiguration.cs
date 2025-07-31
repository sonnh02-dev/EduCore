using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable("SubCategories", Schemas.Course);
            builder.HasKey(subCate => subCate.Id).HasName("PK_SubCategories_Id");
            builder.HasIndex(subCate => subCate.CategoryId, "IX_SubCategories_CategoryId");

            builder.Property(subCate => subCate.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(subCate => subCate.Category)
                .WithMany(cate => cate.SubCategories)
                .HasForeignKey(subCate => subCate.CategoryId)
                .HasConstraintName("FK_SubCategories_CategoryId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new SubCategory { Id = 1, Name = "Web Development", CategoryId = 1 },
                new SubCategory { Id = 2, Name = "Data Science", CategoryId = 1 },
                new SubCategory { Id = 3, Name = "Mobile Development", CategoryId = 1 },
                new SubCategory { Id = 4, Name = "Game Development", CategoryId = 1 },
                new SubCategory { Id = 5, Name = "Programming Languages", CategoryId = 1 },
                new SubCategory { Id = 6, Name = "Database Design", CategoryId = 1 },
                new SubCategory { Id = 7, Name = "Software Testing", CategoryId = 1 },
                new SubCategory { Id = 8, Name = "DevOps", CategoryId = 1 },
                new SubCategory { Id = 9, Name = "Cloud Computing", CategoryId = 1 },
                new SubCategory { Id = 10, Name = "Cyber Security", CategoryId = 1 },

                new SubCategory { Id = 11, Name = "Entrepreneurship", CategoryId = 2 },
                new SubCategory { Id = 12, Name = "Accounting", CategoryId = 3 },
                new SubCategory { Id = 13, Name = "Network & Security", CategoryId = 4 },
                new SubCategory { Id = 14, Name = "Microsoft Office", CategoryId = 5 },
                new SubCategory { Id = 15, Name = "Productivity Hacks", CategoryId = 6 },
                new SubCategory { Id = 16, Name = "UX/UI Design", CategoryId = 7 },
                new SubCategory { Id = 17, Name = "Social Media Marketing", CategoryId = 8 },
                new SubCategory { Id = 18, Name = "Video Production", CategoryId = 10 }
            );

        }
    }
}
