namespace PaymentsApiCore.Models.Requests
{
    public class AuthenticationKeyRequest
    {
        public string PaymentMethod { get; set; }
        public string Channel { get; set; }
        public string ChannelType { get; set; }
    }
}
