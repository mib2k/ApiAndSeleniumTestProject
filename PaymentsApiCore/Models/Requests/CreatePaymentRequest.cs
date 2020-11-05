namespace PaymentsApiCore.Models.Requests
{
    public class CreatePaymentRequest
    {
        public string Channel { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentData { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string ChannelType { get; set; }
        public string DccTransactionId { get; set; }
    }
}
