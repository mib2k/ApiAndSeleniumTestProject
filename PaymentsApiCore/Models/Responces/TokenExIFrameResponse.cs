using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models.Responces
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
