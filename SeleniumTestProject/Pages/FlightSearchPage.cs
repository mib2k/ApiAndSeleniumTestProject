using OpenQA.Selenium;
using SeleniumTestProject.ElementExtensions;
using SeleniumTestProject.Utils;
using System.Collections.Generic;
using TestContext;
using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.Pages
{
    public class FlightSearchPage : BasePage
    {
        public IWebElement FlightSearchContainer =>
            Driver.FindElement(By.XPath("//*[@data-test-id='test_fsrp_content']"));

        public IList<IWebElement> FareRows =>
            Driver.FindElements(By.XPath("//*[contains(@data-test-id, 'test_row_')]"));

        public void SelectFareAndProccedToNextPage()
        {
            //Proceed to next page
            var continueBtn = FlightSearchContainer.FindElement(By.XPath(".//*[@data-test-id='test_button_continue_fsr']"));


            continueBtn.WaitForClickable(5);
            continueBtn.Click();

            WebDriverUtils.SaveCookieByName("correlationId");
        }
    }
}