using EduCore.BackEnd.Domain.Common.Enumerations;

namespace EduCore.BackEnd.Domain.Common.Enumerations
{
    public sealed class PaymentStatus : Enumeration<PaymentStatus>
    {
        public static readonly PaymentStatus Pending = new(0, "Pending");
        public static readonly PaymentStatus Completed = new(1, "Completed");
        public static readonly PaymentStatus Failed = new(2, "Failed");
        public static readonly PaymentStatus Cancelled = new(3, "Cancelled");
        public static readonly PaymentStatus Refunded = new(4, "Refunded");

        private PaymentStatus(int value, string name) : base(value, name) { }

        public bool IsFinal =>
            this == Completed || this == Failed || this == Cancelled || this == Refunded;

        public bool IsSuccess =>
            this == Completed || this == Refunded;

        public bool IsPending =>
            this == Pending;
    }
}
