using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models.Responces
{
    public class AuthenticationKeyResponse
    {
        private const long serialVersionUID = 1L;

        public string AuthenticationKey { get; set; }
        public string Timestamp { get; set; }
        public string TokProviderClientId { get; set; }
        public string TokenScheme { get; set; }
        public string Origin { get; set; }
        public string JsLibrary { get; set; }
        internal ConfigData ConfigData { get; set; }
    }
}
