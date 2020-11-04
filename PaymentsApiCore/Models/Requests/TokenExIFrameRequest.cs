using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models.Requests
{
    public class TokenExIFrameRequest
    {
        private string tokenExId;
        private string origin;
        private string authenticationKey;
        private string timestamp;
        private string data;
        private string cvvValue;
        private string tokenScheme;
        private bool cvvOnly;
        private bool pci;
        private bool cvv;

        public string TokenExId { get => tokenExId; set => tokenExId = value; }
        public string Origin { get => origin; set => origin = value; }
        public string AuthenticationKey { get => authenticationKey; set => authenticationKey = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }
        public string Data { get => data; set => data = value; }
        public string CvvValue { get => cvvValue; set => cvvValue = value; }
        public string TokenScheme { get => tokenScheme; set => tokenScheme = value; }
        public bool CvvOnly { get => cvvOnly; set => cvvOnly = value; }
        public bool Pci { get => pci; set => pci = value; }
        public bool Cvv { get => cvv; set => cvv = value; }
    }
}
