using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTestProject.Pages
{
    public class PurchasePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_total']")]
        public IWebElement TotalAmount { get; private set; }
    }
}