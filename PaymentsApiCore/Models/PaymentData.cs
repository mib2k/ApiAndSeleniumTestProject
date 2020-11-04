using PaymentsApiCore.Models.Responces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentsApiCore.Models
{
    class PaymentData
    {

        private PaymentTokenObject paymentToken;
        private PaymentInstrument paymentInstrument;
        private PaymentDataExt paymentDataExt;
        private BrowserData browserData;
        private string tokenSource;
        private string sha1hash;


        public void PreparePaymentData(TokenExIFrameResponse tokenExRs)
        {
            paymentToken = BuildPaymentTokenObject(tokenExRs);
            paymentInstrument = BuildPaymentInstrument();
            paymentDataExt = BuildPaymentDataExt();
            tokenSource = "TOKEN_EX";
            sha1hash = tokenExRs.TokenHMAC;
            browserData = BuildBrowserData();
        }




        private PaymentTokenObject BuildPaymentTokenObject(TokenExIFrameResponse tokenExRS)
        {

            PaymentTokenObject _paymentTokenObject = new PaymentTokenObject();

            _paymentTokenObject.PaymentAccountIdentifierToken = tokenExRS.Token;

            _paymentTokenObject.ExpMonth = DateTime.Now.AddMonths(6).Month.ToString();
            _paymentTokenObject.ExpYear = DateTime.Now.AddYears(2).Year.ToString();
            _paymentTokenObject.FirstName = "Jane";
            _paymentTokenObject.LastName = "Doe";
            return _paymentTokenObject;
        }
        private PaymentInstrument BuildPaymentInstrument()
        {

            PaymentInstrument _paymentInstrument = new PaymentInstrument();

            string CardNumber = "4263970000005262";
            string identifier = CardNumber.Substring(CardNumber.Length - 4);

            _paymentInstrument.Type = "CARD";
            _paymentInstrument.CardType = "CRD";
            _paymentInstrument.SubType = "VI";
            _paymentInstrument.UniqueIdentifier = CardNumber.Substring(0, 6);
            _paymentInstrument.Identifier = identifier;
            _paymentInstrument.Description = "VISA" + identifier;
            _paymentInstrument.Expiry = DateTime.Now.AddMonths(6).Month.ToString();
            _paymentInstrument.HolderName = "Jane Doe";
            return _paymentInstrument;
        }
        private PaymentDataExt BuildPaymentDataExt()
        {

            PaymentDataExt _paymentDataExt = new PaymentDataExt();
            _paymentDataExt.ShippingContact = new ShippingContact();

            _paymentDataExt.ShippingContact.FirstName = "Jane";
            _paymentDataExt.ShippingContact.LastName = "Doe";
            _paymentDataExt.ShippingContact.CountryCode = "EI";

            _paymentDataExt.ShippingContact.PostalCode = "12345";

            _paymentDataExt.BillingContact = new BillingContact();
            _paymentDataExt.BillingContact.FirstName = "Jane";
            _paymentDataExt.BillingContact.LastName = "Doe";
            _paymentDataExt.BillingContact.CountryCode = "EI";
            _paymentDataExt.BillingContact.PostalCode = "12345";
            _paymentDataExt.BillingContact.AddressLine1 = "Addr1";
            _paymentDataExt.BillingContact.City = "Cty";

            _paymentDataExt.Phone = new Phone();
            _paymentDataExt.Phone.Code = "11";
            _paymentDataExt.Phone.Number = "12345654";

            _paymentDataExt.Email = "Jane.Doe@test.com";
            return _paymentDataExt;
        }

        private BrowserData BuildBrowserData()
        {
            BrowserData _browserData = new BrowserData();
            _browserData.AcceptHeader = "application/json, text/plain, */*";
            _browserData.ChallengeWindowSize = "WINDOWED_600X400";
            _browserData.ColorDepth = "TWENTY_FOUR_BITS";
            _browserData.JavascriptEnabled = "false";
            _browserData.JavaEnabled = "false";
            _browserData.Language = "en-AU";
            _browserData.ScreenHeight = "1200";
            _browserData.ScreenWidth = "1200";
            _browserData.Timezone = "-1";
            _browserData.UserAgent = "Mozilla / 5.0(Macintosh; Intel Mac OS X 10_14_5) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 75.0.3770.142 Safari / 537.36";

            return _browserData;
        }
        private class PaymentTokenObject
        {
            private string cvvNumber;

            public string PaymentAccountIdentifierToken { get; set; }
            public string ExpMonth { get; set; }
            public string ExpYear { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CvvNumber
            {
                get { return "CVV"; }
                set => cvvNumber = value;
            }
        }
        private class PaymentInstrument
        {
            public string Type { get; set; }
            public string CardType { get; set; }
            public string SubType { get; set; }
            public string UniqueIdentifier { get; set; }
            public string Identifier { get; set; }
            public string Description { get; set; }
            public string Expiry { get; set; }
            public string HolderName { get; set; }
        }
        private class PaymentDataExt
        {
            public ShippingContact ShippingContact { get; set; }
            public BillingContact BillingContact { get; set; }
            public Phone Phone { get; set; }
            public string Email { get; set; }
        }



        private class BrowserData
        {
            public string AcceptHeader { get; set; }
            public string ChallengeWindowSize { get; set; }
            public string ColorDepth { get; set; }
            public string JavascriptEnabled { get; set; }
            public string JavaEnabled { get; set; }
            public string Language { get; set; }
            public string ScreenHeight { get; set; }
            public string ScreenWidth { get; set; }
            public string Timezone { get; set; }
            public string UserAgent { get; set; }
        }

        private class ShippingContact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CountryCode { get; set; }
            public string PostalCode { get; set; }
        }

        private class BillingContact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CountryCode { get; set; }
            public string PostalCode { get; set; }
            public string AddressLine1 { get; set; }
            public string City { get; set; }
        }
        private class Phone
        {
            public string Code { get; set; }// 11
            public string Number { get; set; } // 1231321
        }
    }

}
