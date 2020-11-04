using SeleniumTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumTestProject.ElementExtensions;

namespace SeleniumTestProject
{
    public class PurchasePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_total']")]
        public IWebElement TotalAmount { get; private set; }

    }
}