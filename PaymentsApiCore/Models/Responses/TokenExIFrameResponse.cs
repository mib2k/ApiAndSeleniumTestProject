namespace PaymentsApiCore.Models.Responses
{
    public class TokenExIFrameResponse
    {
        public string FirstSix { get; set; }
        public string LastFour { get; set; }
        public string Token { get; set; }
        public string ReferenceNumber { get; set; }
        public string TokenHMAC { get; set; }
    }
}
