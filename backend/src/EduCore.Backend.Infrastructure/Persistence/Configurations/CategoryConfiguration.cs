using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Domain.Common.Entities;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", Schemas.Course);

            builder.HasKey(cate => cate.Id).HasName("PK_Categories_Id");

            builder.Property(c => c.Id)
                  .HasConversion(
                    id => id.Value,
                    value => new Id<Category>(value));

            builder.Property(cate => cate.Name).HasMaxLength(50);

            builder.HasData(
                new Category { Id = 1, Name = "Development" },
                new Category { Id = 2, Name = "Business" },
                new Category { Id = 3, Name = "Finance & Accounting" },
                new Category { Id = 4, Name = "IT & Software" },
                new Category { Id = 5, Name = "Office Productivity" },
                new Category { Id = 6, Name = "Personal Development" },
                new Category { Id = 7, Name = "Design" },
                new Category { Id = 8, Name = "Marketing" },
                new Category { Id = 9, Name = "Lifestyle" },
                new Category { Id = 10, Name = "Photography & Video" }
            );
        }
    }

}
