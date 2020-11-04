using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.ElementExtensions
{
    public static class WebElementExtensions
    {
        public static void WaitForVisible(this IWebElement element, int TimeToWait)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(TimeToWait)).Until(d => element.Displayed && element.Enabled);
        }

        public static void WaitForClickable(this IWebElement element, int TimeToWait)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(TimeToWait));
            wait.Until(driver => element.Displayed && element.Enabled);
            wait.Until(driver => SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
