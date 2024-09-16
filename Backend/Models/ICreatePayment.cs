namespace Backend.Models.Interfaces.CreatePayment
{
    public interface ICreatePaymentRequest
    {
        string Holder { get; set; }
        string CardNumber { get; set; }
        string ExpirationDate { get; set; }
        string Brand { get; set; }
        string SecurityCode { get; set; }
    }
}