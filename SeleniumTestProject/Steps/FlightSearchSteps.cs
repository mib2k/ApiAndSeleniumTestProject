using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestProject.ElementExtensions;
using SeleniumTestProject.Pages;
using SeleniumTestProject.Utils;
using System.Linq;
using TestContext;

namespace SeleniumTestProject.Steps
{
    public class FlightSearchSteps : BaseSteps
    {
        private FlightSearchPage _flightSearchPage => new FlightSearchPage();


        public void AssertFares()
        {
            Assert.IsTrue(_flightSearchPage.FareRows.Count > 0, "No fares found");
        }

        public void SelectFare(double? price = null)
        {
            var FirstAvailableFare = _flightSearchPage.FareRows.First();

            //Selecting flight
            FirstAvailableFare.FindElement(By.XPath(".//*[contains(@data-test-id, 'test_fare_category')]")).Click();

            //Selecting fare
            var fare = FirstAvailableFare.FindElement(By.XPath(".//*[contains(@data-test-id, 'test_fare_button_') and not(@disabled)]"));
            fare.WaitForVisible(5);
            fare.Click();

            //Proceed to next page
            _flightSearchPage.SelectFareAndProccedToNextPage();
        }
    }
}
