using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTestProject.Pages
{
    class LandingPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        public IWebElement AcceptCookies { get; private set; }

        [FindsBy(How = How.Id, Using = "locale-confirm-button")]
        public IWebElement ConfirmLocaleBtn { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'homepage_roundtrip')]")]
        public IWebElement RoundTripRadio { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@id, 'homepage_oneway')]")]
        public IWebElement OneWayRadio { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='origin']")]
        public IWebElement OriginInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='dest']")]
        public IWebElement DestinationInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_booker_outbound_calendar']")]
        public IWebElement PickerOutboundDateInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_booker_inbound_calendar']")]
        public IWebElement PickerInboundDateInput { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'datepicker-container')]")]
        public IWebElement PickerCalendar { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_booker_search']")]
        public IWebElement SearchFlightsButton { get; private set; }
    }
}
