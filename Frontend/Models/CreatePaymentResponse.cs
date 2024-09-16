namespace Frontend.Models.Response
{
    public class CreatePaymentResponse
    {
        public string MerchantOrderId { get; set; }

        public Customer Customer { get; set; }

        public Payment Payment { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
    }

    public
     class Payment
    {
        public decimal ServiceTaxAmount { get; set; }
        public int Installments { get; set; }
        public decimal Interest { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public bool Recurrent { get; set; }

        public string Tid { get; set; }
        public string ProofOfSale { get; set; }
        public
     string AuthorizationCode { get; set; }
        public string SoftDescriptor { get; set; }
        public string Provider
        { get; set; }
        public bool IsQrCode { get; set; }
        public decimal Amount { get; set; }
        public string ReceivedDate { get; set; }
        public int Status { get; set; }
        public bool IsSplitted { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnCode { get; set; }
        public string PaymentId { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public List<Link> Links { get; set; }
    }

    public class Link
    {
        public string Method { get; set; }
        public string Rel { get; set; }
        public string Href { get; set; }
    }
}