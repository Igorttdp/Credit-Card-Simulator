using Frontend.Services.Interfaces;

namespace Frontend.Services
{
    public class BackendService : IBackendService
    {
        private readonly HttpClient httpClient;

        public BackendService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<object> CancelPayment()
        {
            // return await this.httpClient.PostAsJsonAsync("/createPayment", null);
            throw new NotImplementedException();
        }

        public Task<object> CapturePayment()
        {
            throw new NotImplementedException();
        }

        public Task<object> CreatePayment()
        {
            throw new NotImplementedException();
        }
    }
}