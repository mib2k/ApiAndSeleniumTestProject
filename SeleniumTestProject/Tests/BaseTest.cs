using NUnit.Framework;
using System.Collections.Generic;
using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestProject.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://www-devk2.aerlingus.com");
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            CloseDriver();
        }
    }
}
