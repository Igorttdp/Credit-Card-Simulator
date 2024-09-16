using Backend.Models.Interfaces.CreatePayment;

namespace Backend.Models.CreatePayment
{
    public class CreatePaymentRequest(string Holder, string CardNumber, string ExpirationDate, string Brand, string SecurityCode) : ICreatePaymentRequest
    {
        public string Holder { get; set; } = Holder;
        public string CardNumber { get; set; } = CardNumber;
        public string ExpirationDate { get; set; } = ExpirationDate;
        public string Brand { get; set; } = Brand;
        public string SecurityCode { get; set; } = SecurityCode;
    }

    public class Sales(CreatePaymentRequest CreditCard)
    {
        public string MerchantOrderId { get; set; } = "2014111703";
        public Payment Payment { get; set; } = new Payment(CreditCard);
    }

    public class Payment(CreatePaymentRequest CreditCard)
    {
        public string Type { get; set; } = "CreditCard";
        public int Amount { get; set; } = 1600;
        public int Installments { get; set; } = 1;
        public string SoftDescriptor { get; set; } = "123456789ABCD";
        public bool Capture { get; set; } = false;
        public CreatePaymentRequest CreditCard { get; set; } = CreditCard;
    }
}