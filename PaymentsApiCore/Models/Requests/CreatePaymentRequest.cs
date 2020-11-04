using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models
{
    public class CreatePaymentRequest
    {
        private string channel;
        private string paymentMethod;
        private string paymentData;
        private Decimal amount;
        private string currencyCode;
        private string channelType;
        private string dccTransactionId;

        public string Channel { get => channel; set => channel = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string PaymentData { get => paymentData; set => paymentData = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string CurrencyCode { get => currencyCode; set => currencyCode = value; }
        public string ChannelType { get => channelType; set => channelType = value; }
        public string DccTransactionId { get => dccTransactionId; set => dccTransactionId = value; }
    }
}
