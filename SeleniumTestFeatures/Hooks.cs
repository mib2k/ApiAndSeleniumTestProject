using TechTalk.SpecFlow;
using static SeleniumTestProject.Utils.WebDriverManager;

namespace SeleniumTestFeatures
{
    [Binding]
    class Hooks
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://www-devk1.aerlingus.com");
        }


        [AfterScenario]
        public void ShutDown()
        {
            CloseDriver();
        }
    }
}
