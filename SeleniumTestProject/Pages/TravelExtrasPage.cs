using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumTestProject.Pages;

namespace SeleniumTestProject
{
    public class TravelExtrasPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_button_continue_extras']")]
        public IWebElement ContinueBtn{ get; }
    }
}