namespace PaymentsApiCore.Models
{
    class ConfigData
    {
        private const long serialVersionUID = 1L;

        public bool AllowUnknownCardTypes { get; set; }
        public bool Cvv { get; set; }
    }
}
