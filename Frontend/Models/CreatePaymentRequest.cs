namespace Frontend.Models.Request
{
    public class CreatePaymentRequest()
    {
        public string Holder { get; set; } = "";
        public string CardNumber { get; set; } = "";
        public string ExpirationDate { get; set; } = "";
        public string Brand { get; set; } = "";
        public string SecurityCode { get; set; } = "";
    }
}