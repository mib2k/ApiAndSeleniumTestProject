﻿using Newtonsoft.Json;

namespace PaymentsApiCore.Models.Responses
{
    public class AuthenticationKeyResponse
    {
        //[JsonIgnore]
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
