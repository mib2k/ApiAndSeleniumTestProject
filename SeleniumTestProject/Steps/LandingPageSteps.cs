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

        public void SetAirports(string @from, string to)
        {
            _landingPage.OriginInput.Click();
            _landingPage.OriginInput.SendKeys(@from);
            _landingPage.OriginInput.SendKeys(Keys.Enter);

            _landingPage.DestinationInput.Click();
            _landingPage.DestinationInput.SendKeys(to);
            _landingPage.DestinationInput.SendKeys(Keys.Enter);
        }

        public void SetDates(DateTime dateFrom, DateTime? dateTo = null)
        {
            _landingPage.PickerOutboundDateInput.Click();
            var daysCollection = _landingPage.PickerCalendar.FindElements(
                By.XPath(".//*[contains(@class, 'ui-state-default') and(not(ancestor::*[contains(@class, 'ui-datepicker-unselectable')]))]")).ToList();

            var dayFrom = daysCollection.First(e => e.Text == dateFrom.Day.ToString());
            dayFrom.Click();
            if (dateTo != null)
            {
                var dayTo = daysCollection.First(e => e.Text == dateTo?.Day.ToString());
                dayTo.Click();
            }
        }

        public void Search()
        {
            _landingPage.SearchFlightsButton.Click();
        }
    }
}
