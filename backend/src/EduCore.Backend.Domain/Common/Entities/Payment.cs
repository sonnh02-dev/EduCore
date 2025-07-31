using EduCore.BackEnd.Domain.Common.Enumerations;

namespace EduCore.BackEnd.Domain.Common.Entities
{
    public abstract class Payment : AuditableAggregateRoot<Payment>
    {
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string TransactionId { get; set; } = null!;
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public string PaymentType { get; set; } = string.Empty;
    }

}
