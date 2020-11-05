using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTestProject.Pages
{
    public class TravelExtrasPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_button_continue_extras']")]
        public IWebElement ContinueBtn{ get; }
    }
}