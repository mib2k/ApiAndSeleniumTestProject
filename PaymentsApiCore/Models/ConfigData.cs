using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models
{
    class ConfigData
    {
        private const long serialVersionUID = 1L;
        private Boolean allowUnknownCardTypes;
        private Boolean cvv;

        public bool AllowUnknownCardTypes { get => allowUnknownCardTypes; set => allowUnknownCardTypes = value; }
        public bool Cvv { get => cvv; set => cvv = value; }
    }
}
