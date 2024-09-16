namespace Frontend.Services.Interfaces
{
    public interface IBackendService
    {
        Task<object> CreatePayment();
        Task<object> CapturePayment();
        Task<object> CancelPayment();
    }
}

