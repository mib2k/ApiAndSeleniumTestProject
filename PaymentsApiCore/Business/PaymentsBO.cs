using PaymentsApiCore.Client;
using PaymentsApiCore.Models;
using PaymentsApiCore.Models.Requests;
using PaymentsApiCore.Models.Responses;

namespace PaymentsApiCore.Business
{
    class PaymentsBO
    {
        public static string CardPayment => "CARD";
        public static string WebChannel => "web";
        private readonly PaymentClient client;

        public PaymentsBO()
        {
            client = new PaymentClient();
        }

        public void AuthenticatePayment()
        {
            var authRQ = new AuthenticationKeyRequest
            {
                Channel = WebChannel,
                PaymentMethod = CardPayment
            };

            var authResponse = client.AuthenticatePayment(authRQ);
        }

        public TokenExIFrameResponse GetTokenExResponse(AuthenticationKeyResponse authResponse)
        {
            var tokenRequest = new TokenExIFrameRequest
            {
                AuthenticationKey = authResponse.AuthenticationKey,
                TokenExId         = authResponse.TokProviderClientId,
                Origin            = authResponse.Origin,
                Timestamp         = authResponse.Timestamp,
                Data              = "4263970000005262",
                CvvValue          = "123",
                TokenScheme       = authResponse.TokenScheme,
                CvvOnly           = false,
                Pci               = true,
                Cvv               = true
            };

            var tokenResponse = client.TokenEx(tokenRequest);
            return tokenResponse;
        }

        public CreatePaymentResponse CreatePayment(decimal totalAmount, string currencyCode, TokenExIFrameResponse tokenResponse)
        {
            var paymentRequest = new CreatePaymentRequest
            {
                Channel       = WebChannel,
                PaymentMethod = CardPayment,
                Amount        = totalAmount,
                CurrencyCode  = currencyCode
            };

            var paymentData = new PaymentData();
            paymentData.PreparePaymentData(tokenResponse);
            paymentRequest.PaymentData = paymentData.ToString();
            var paymentResponse = client.CreatePayment(paymentRequest);
            return paymentResponse;
        }
    }
}
