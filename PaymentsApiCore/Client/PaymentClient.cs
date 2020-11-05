using Newtonsoft.Json;
using PaymentsApiCore.Models.Requests;
using PaymentsApiCore.Models.Responses;
using RestSharp;

namespace PaymentsApiCore.Client
{
    public class PaymentClient
    {
        public AuthenticationKeyResponse AuthenticatePayment(AuthenticationKeyRequest request) 
            => RequestExecution<AuthenticationKeyResponse, AuthenticationKeyRequest>(request, PaymentsResource.baseUrl + "/paymentshub/api/v1/authenticationkey");

        public TokenExIFrameResponse TokenEx(TokenExIFrameRequest request) 
            => RequestExecution<TokenExIFrameResponse, TokenExIFrameRequest>(request, "https://test-htp.tokenex.com/iframe/v3");

        public CreatePaymentResponse CreatePayment(CreatePaymentRequest request) 
            => RequestExecution<CreatePaymentResponse, CreatePaymentRequest>(request, PaymentsResource.baseUrl + "/paymentshub/api/v1/payments");

        private TResponse RequestExecution<TResponse, TRequest>(TRequest request, string url) where TResponse : class where TRequest : class
        {
            var payload= JsonConvert.SerializeObject(request);
            var response = SendRequest(url, payload);
            var jsonResponse = JsonConvert.DeserializeObject<TResponse>(response.Content);
            return jsonResponse;
        }

        private IRestResponse SendRequest(string url, string payload)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(payload);
            request.AddHeader("X-CorrelationId", "value");
            request.AddHeader("X-Origin", PaymentsResource.baseUrl);
            var response = client.Execute(request);
            return response;
        }
    }
}
