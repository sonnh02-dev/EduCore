using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Domain.Common.Enumerations;
using EduCore.BackEnd.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCore.BackEnd.Infrastructure.Persistence.Configurations
{
    internal class StudentPaymentConfiguration : IEntityTypeConfiguration<StudentPayment>

    {
        public void Configure(EntityTypeBuilder<StudentPayment> builder)
        {
            builder.HasIndex(sp => sp.EnrollmentId, "IX_StudentPayments_EnrollmentId").IsUnique();

            builder.HasOne(sp => sp.Enrollment)
                    .WithOne(e => e.Payment)
                    .HasForeignKey<StudentPayment>(sp => sp.EnrollmentId)
                    .HasConstraintName("FK_StudentPayments_Enrollments_EnrollmentId")
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new StudentPayment
                {
                    Id = 1,
                    EnrollmentId = 1,
                    Status = PaymentStatus.Completed,
                    TransactionId = "TXN1001",
                    PaymentMethod = PaymentMethod.CreditCard,
                    Amount = 499000m,
                    PaymentDate = new DateTime(2024, 6, 15),
                    Discriminator = nameof(StudentPayment)
                },
                new StudentPayment
                {
                    Id = 2,
                    EnrollmentId = 2,
                    Status = PaymentStatus.Completed,
                    TransactionId = "TXN1002",
                    PaymentMethod = PaymentMethod.PayPal,
                    Amount = 699000m,
                    PaymentDate = new DateTime(2024, 7, 1),
                    Discriminator = nameof(StudentPayment)
                },
                new StudentPayment
                {
                    Id = 3,
                    EnrollmentId = 3,
                    Status = PaymentStatus.Completed,
                    TransactionId = "TXN1003",
                    PaymentMethod = PaymentMethod.CreditCard,
                    Amount = 499000m,
                    PaymentDate = new DateTime(2024, 7, 5),
                    Discriminator = nameof(StudentPayment)
                },
                new StudentPayment
                {
                    Id = 4,
                    EnrollmentId = 4,
                    Status = PaymentStatus.Completed,
                    TransactionId = "TXN1004",
                    PaymentMethod = PaymentMethod.PayPal,
                    Amount = 699000m,
                    PaymentDate = new DateTime(2024, 7, 7),
                    Discriminator = nameof(StudentPayment)
                }
            );
        }
    }
}
