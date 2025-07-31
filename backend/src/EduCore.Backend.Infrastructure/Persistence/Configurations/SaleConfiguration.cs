using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EduCore.BackEnd.Infrastructure.Persistence.Configurations;
using EduCore.BackEnd.Domain.Aggregates.SaleAggregate;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale", Schemas.Course);

            builder.HasKey(sale => sale.Id).HasName("PK_Sales_Id");

            builder.Property(sale => sale.DiscountPercent)
                  .IsRequired();

            builder.Property(sale => sale.StartDate)
                    .HasColumnType("datetime")
                    .IsRequired();

            builder.Property(sale => sale.EndDate)
                    .HasColumnType("datetime")
                    .IsRequired();

            builder.HasOne(sale => sale.Course)
                  .WithMany(c => c.Sales)
                  .HasForeignKey(sale => sale.CourseId)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Sale { Id = 1, CourseId = 1, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 2, CourseId = 2, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 3, CourseId = 3, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 4, CourseId = 4, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 5, CourseId = 5, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 6, CourseId = 6, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 7, CourseId = 7, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 8, CourseId = 8, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 9, CourseId = 9, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 10, CourseId = 10, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 11, CourseId = 11, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 12, CourseId = 12, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 13, CourseId = 13, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 14, CourseId = 14, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 15, CourseId = 15, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 16, CourseId = 16, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 17, CourseId = 17, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 18, CourseId = 18, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 19, CourseId = 19, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },
                new Sale { Id = 20, CourseId = 20, DiscountPercent = 40, StartDate = new DateTime(2025, 1, 25), EndDate = new DateTime(2025, 2, 5) },

                // 30/4 - 1/5: 25%
                new Sale { Id = 21, CourseId = 1, DiscountPercent = 25, StartDate = new DateTime(2025, 4, 30), EndDate = new DateTime(2025, 5, 1) },
                new Sale { Id = 22, CourseId = 2, DiscountPercent = 25, StartDate = new DateTime(2025, 4, 30), EndDate = new DateTime(2025, 5, 1) }
                

            );

        }
    }
}
