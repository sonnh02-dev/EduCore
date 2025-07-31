
namespace EduCore.BackEnd.Domain.Common.Enumerations
{
    public sealed class PaymentMethod : Enumeration<PaymentMethod>
    {
        public static readonly PaymentMethod CreditCard = new(1, "CreditCard");
        public static readonly PaymentMethod PayPal = new(2, "PayPal");
        public static readonly PaymentMethod VNPay = new(3, "VNPay");
        public static readonly PaymentMethod Momo = new(4, "Momo");
        public static readonly PaymentMethod ZaloPay = new(5, "ZaloPay");
        public static readonly PaymentMethod BankTransfer = new(6, "BankTransfer");
        public static readonly PaymentMethod Cash = new(7, "Cash");

        private PaymentMethod(int value, string name) : base(value, name) { }

        public bool IsDigitalWallet =>
            this == Momo || this == ZaloPay || this == VNPay;

        public bool IsCard =>
            this == CreditCard || this == PayPal;
    }
}
