using System.Text;
using System.Text.Json;
using Backend.Models.CreatePayment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Backend.Controllers.Cielo
{
    [ApiController]
    [Route("/")]
    public class CieloController : ControllerBase
    {
        private HttpClient httpClient { get; set; }
        public CieloController()
        {
            this.httpClient = new()
            {
                BaseAddress = new Uri("https://apisandbox.cieloecommerce.cielo.com.br/"),
            };

            this.httpClient.DefaultRequestHeaders.Add("MerchantId", "f3fdde16-8822-47ed-9d5b-5ffa5b548e83");
            this.httpClient.DefaultRequestHeaders.Add("MerchantKey", "ETGQVAQNOEAVJMACVYRBUKXXHOSNZCKXFGWGTYFR");
        }

        [HttpPost("/createPayment")]
        public async Task<IActionResult> CreatePayment([FromBody, BindRequired] CreatePaymentRequest body)
        {
            Sales sales = new(body);
            var jsonContent = JsonSerializer.Serialize(sales);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/1/sales", content);
            var bodyContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return Ok(bodyContent);
            }

            return BadRequest(bodyContent);
        }

        [HttpPut("/capturePayment")]
        public async Task<IActionResult> CapturePayment([FromQuery, BindRequired] string PaymentId)
        {
            var response = await httpClient.PutAsync(@$"/1/sales/{PaymentId}/capture", null);
            var bodyContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return Ok(bodyContent);
            }

            return BadRequest(bodyContent);
        }

        [HttpPut("/cancelPayment")]
        public async Task<IActionResult> CancelPayment([FromQuery, BindRequired] string PaymentId)
        {
            var response = await httpClient.PutAsync(@$"/1/sales/{PaymentId}/void", null);
            var bodyContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return Ok(bodyContent);
            }

            return BadRequest(bodyContent);
        }

    }
}