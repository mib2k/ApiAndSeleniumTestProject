using Newtonsoft.Json;
using PaymentsApiCore.Models;
using PaymentsApiCore.Models.Requests;
using PaymentsApiCore.Models.Responces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Business
{
    class PaymentsBO
    {
        public static string CARD_PAYMENT = "CARD";
        public static string WEB_CHANNEL = "web";
        private PaymentClient client;

        public PaymentsBO()
        {
            this.client = new PaymentClient();
        }

        public void AuthenticatePayment()
        {
            AuthenticationKeyRequest authRQ = new AuthenticationKeyRequest
            {
                Channel = WEB_CHANNEL,
                PaymentMethod = CARD_PAYMENT
            };

            AuthenticationKeyResponse authRS = client.AuthenticatePayment(authRQ);
        }

        public TokenExIFrameResponse GetTokenExResponse(AuthenticationKeyResponse authRS)
        {
            TokenExIFrameRequest tokenExRQ = new TokenExIFrameRequest
            {
                AuthenticationKey = authRS.AuthenticationKey,
                TokenExId = authRS.TokProviderClientId,
                Origin = authRS.Origin,

                Timestamp = authRS.Timestamp,
                Data = "4263970000005262",
                CvvValue = "123",
                TokenScheme = authRS.TokenScheme,
                CvvOnly = false,
                Pci = true,
                Cvv = true
            };

            TokenExIFrameResponse tokenExRS = client.TokenEx(tokenExRQ);

            return tokenExRS;
        }

        public CreatePaymentResponse CreatePayment(Decimal TotalAmount, string CurrencyCode, TokenExIFrameResponse TokenExRs)
        {
            CreatePaymentRequest createPaymentRequest = new CreatePaymentRequest
            {
                Channel = WEB_CHANNEL,
                PaymentMethod = CARD_PAYMENT,
                Amount = TotalAmount,
                CurrencyCode = CurrencyCode
            };
            PaymentData paymentData = new PaymentData();
            paymentData.PreparePaymentData(TokenExRs);
            createPaymentRequest.PaymentData = paymentData.ToString();
            return client.CreatePayment(createPaymentRequest);
        }
    }
}
