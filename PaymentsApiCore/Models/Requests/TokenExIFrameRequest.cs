namespace PaymentsApiCore.Models.Requests
{
    public class TokenExIFrameRequest
    {
        public string TokenExId { get; set; }
        public string Origin { get; set; }
        public string AuthenticationKey { get; set; }
        public string Timestamp { get; set; }
        public string Data { get; set; }
        public string CvvValue { get; set; }
        public string TokenScheme { get; set; }
        public bool CvvOnly { get; set; }
        public bool Pci { get; set; }
        public bool Cvv { get; set; }
    }
}
