using OpenQA.Selenium;
using SeleniumTestProject.ElementExtensions;
using SeleniumTestProject.Pages;
using System;
using System.Linq;


namespace SeleniumTestProject.Steps
{
    public class LandingPageSteps : BaseSteps
    {
        private LandingPage _landingPage => new LandingPage();

        public void AcceptCookiesAndLocation()
        {
            _landingPage.AcceptCookies.WaitForVisible(10);
            _landingPage.AcceptCookies.Click();
            _landingPage.ConfirmLocaleBtn.Click();
        }

        public void SelectOneWayTrip()
        {
            _landingPage.OneWayRadio.Click();
        }

        public void SetAirports(string From, string To)
        {
            _landingPage.OriginInput.Click();
            _landingPage.OriginInput.SendKeys(From);
            _landingPage.OriginInput.SendKeys(Keys.Enter);

            _landingPage.DestinationInput.Click();
            _landingPage.DestinationInput.SendKeys(To);
            _landingPage.DestinationInput.SendKeys(Keys.Enter);
        }

        public void SetDates(DateTime DateFrom, DateTime? DateTo = null)
        {
            _landingPage.PickerOutboundDateInput.Click();
            var daysColletion = _landingPage.PickerCalendar.FindElements(
                By.XPath(".//*[contains(@class, 'ui-state-default') and(not(ancestor::*[contains(@class, 'ui-datepicker-unselectable')]))]")).ToList();

            var DayFrom = daysColletion.Where(e => e.Text == DateFrom.Day.ToString()).First();
            DayFrom.Click();
            if (DateTo != null)
            {
                var DayTo = daysColletion.Where(e => e.Text == DateTo?.Day.ToString()).First();
                DayTo.Click();
            }
        }

        public void Search()
        {
            _landingPage.SearchFlightsButton.Click();
        }
    }
}
