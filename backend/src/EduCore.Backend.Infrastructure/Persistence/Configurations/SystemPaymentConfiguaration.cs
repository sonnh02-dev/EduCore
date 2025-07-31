using EduCore.BackEnd.Domain.Aggregates.InstructorAggregate;
using EduCore.BackEnd.Domain.Common.Enumerations;
using EduCore.BackEnd.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{

    public class SystemPaymentConfiguration : IEntityTypeConfiguration<SystemPayment>
    {
        public void Configure(EntityTypeBuilder<SystemPayment> builder)
        {
            builder.HasOne(sp => sp.InstructorProfile)
                  .WithMany(ip => ip.SystemCheckouts)
                  .HasForeignKey(sp => sp.InstructorProfileId)
                  .HasConstraintName("FK_SystemPayments_Profiles_AccountId")
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new SystemPayment
                {
                    Id = 5,
                    InstructorProfileId = 2,
                    Status = PaymentStatus.Completed,
                    TransactionId = "SYS1001",
                    PaymentMethod = PaymentMethod.BankTransfer,
                    Amount = 1500000m,
                    PaymentDate = new DateTime(2024, 6, 10),
                    Discriminator = nameof(SystemPayment)
                },
                new SystemPayment
                {
                    Id = 6,
                    InstructorProfileId = 3,
                    Status = PaymentStatus.Completed,
                    TransactionId = "SYS1002",
                    PaymentMethod = PaymentMethod.BankTransfer,
                    Amount = 2000000m,
                    PaymentDate = new DateTime(2024, 6, 12),
                    Discriminator = nameof(SystemPayment)
                },
                new SystemPayment
                {
                    Id = 7,
                    InstructorProfileId = 4,
                    Status = PaymentStatus.Completed,
                    TransactionId = "SYS1003",
                    PaymentMethod = PaymentMethod.BankTransfer,
                    Amount = 1700000m,
                    PaymentDate = new DateTime(2024, 6, 13),
                    Discriminator = nameof(SystemPayment)
                },
                new SystemPayment
                {
                    Id = 8,
                    InstructorProfileId = 5,
                    Status = PaymentStatus.Completed,
                    TransactionId = "SYS1004",
                    PaymentMethod = PaymentMethod.BankTransfer,
                    Amount = 1800000m,
                    PaymentDate = new DateTime(2024, 6, 14),
                    Discriminator = nameof(SystemPayment)
                }
            );
        }
    }
}