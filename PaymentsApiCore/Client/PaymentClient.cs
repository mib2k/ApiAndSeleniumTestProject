using Newtonsoft.Json;
using PaymentsApiCore.Models;
using PaymentsApiCore.Models.Requests;
using PaymentsApiCore.Models.Responces;
using RestSharp;
using System;

namespace PaymentsApiCore
{
    public class PaymentClient
    {

        public AuthenticationKeyResponse AuthenticatePayment(AuthenticationKeyRequest request)
        {
            object payload = JsonConvert.SerializeObject(request);
            var response = SendRequest(PaymentsResource.baseUrl + "/paymentshub/api/v1/authenticationkey", payload);
            AuthenticationKeyResponse authResponse = JsonConvert.DeserializeObject<AuthenticationKeyResponse>(response.Content);

            return authResponse;
        }

        public TokenExIFrameResponse TokenEx(TokenExIFrameRequest request)
        {
            object payload = JsonConvert.SerializeObject(request);
            var response = SendRequest("https://test-htp.tokenex.com/iframe/v3", payload);
            TokenExIFrameResponse tokenExResponse = JsonConvert.DeserializeObject<TokenExIFrameResponse>(response.Content);

            return tokenExResponse;


        }

        public CreatePaymentResponse CreatePayment(CreatePaymentRequest request)
        {
            object payload = JsonConvert.SerializeObject(request);
            var response = SendRequest(PaymentsResource.baseUrl + "/paymentshub/api/v1/payments", payload);
            CreatePaymentResponse createPaymentResponse = JsonConvert.DeserializeObject<CreatePaymentResponse>(response.Content);

            return createPaymentResponse;
        }

        private IRestResponse SendRequest(string url, object payload)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(payload);
            request.AddHeader("X-CorrelationId", "value");
            request.AddHeader("X-Origin", PaymentsResource.baseUrl);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
