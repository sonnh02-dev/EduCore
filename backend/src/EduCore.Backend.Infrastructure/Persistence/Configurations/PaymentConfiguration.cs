using EduCore.BackEnd.Domain.Aggregates.InstructorAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments", Schemas.Payment);

            builder.HasKey(pay => pay.Id).HasName("PK_Payments_Id");

            builder.Property(p => p.Status)
                .HasConversion<string>();

            builder.Property(pay => pay.TransactionId).IsRequired();

            builder.Property(pay => pay.PaymentMethod)
                   .HasConversion<string>()
                   .HasMaxLength(50);

            builder.Property(pay => pay.Amount).HasColumnType("decimal(18,2)");
            builder.Property(pay => pay.PaymentDate).HasDefaultValueSql("GETDATE()");

            builder.HasDiscriminator<string>("PaymentType")
               .HasValue<StudentPayment>("StudentPayment")
               .HasValue<SystemPayment>("SystemPayment");

            


        }
    }
}


