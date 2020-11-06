
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.Pages
{
    public class SeatSelectionPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_btn_skip_seat_selection']")]
        public IWebElement SkipSeatSelectionBtn { get; private set; }

        public IWebElement ConfirmNoSeats
        {
            get
            {
                var confirmBtn = By.XPath(".//*[@data-test-id='test_seats_routing_modals_ok_btn']");
                try
                {
                    
                    new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).
                        Until(drv => drv.FindElement(confirmBtn).Displayed);
                }
                catch (Exception)
                {
                    // ignored
                }

                return Driver.FindElement(confirmBtn);
            }
        }
    }
}
