using SeleniumTestProject.Steps;
using System;
using TechTalk.SpecFlow;

namespace SeleniumTestFeatures
{
    [Binding]
    public class MainBookingFlowStepDefinitions
    {
        LandingPageSteps landingSteps = new LandingPageSteps();
        FlightSearchSteps flightSearchSteps = new FlightSearchSteps();

        //SeatSelectionSteps seatSelectionSteps;
        //PaxInfoSteps paxInfo;
        //TravelEssentialsSteps travelEssentialsSteps;
        //TravelExtrasSteps travelExtrasSteps;

        [Given(@"Select departure (.*) and arrival (.*) with type (.*)")]
        public void SelectAirportsWithType(string from, string to, string type)
        {

            landingSteps.AcceptCookiesAndLocation();

            landingSteps.SetAirports(from, to);
            if (type == "ONE_WAY")
            {
                landingSteps.SelectOneWayTrip();
            }
        }

        [Given(@"Select date (.*) days from now")]
        public void SelectDepartureDate(int daysFromNow)
        {
            landingSteps.SetDates(DateTime.Now.AddDays(daysFromNow));
        }

        [When(@"Click Search button")]
        public void WhenClickSearchButton()
        {
            landingSteps.Search();
        }

        [Then(@"FSR page is displayed")]
        public void ThenFSRPageIsDisplayed()
        {
            flightSearchSteps.AssertFares();
        }
    }
}