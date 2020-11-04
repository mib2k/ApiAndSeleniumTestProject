using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using System.Threading;

namespace SeleniumTestProject.Utils
{
    public class WebDriverManager
    {
        private static ThreadLocal<IWebDriver> driverPool = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                Thread.Sleep(500);
                return driverPool.Value ??= CreateAndGetDriver();
            }
        }
        private static IWebDriver CreateAndGetDriver()
        {
            IWebDriver driverProxy = new ChromeDriver();
            driverProxy.Manage().Window.Maximize();

            return driverProxy;
        }

        public static void CloseDriver()
        {
            if (driverPool.IsValueCreated)
            {
                driverPool.Value.Close();
                driverPool.Value.Quit();
                driverPool.Value = null;
            }
        }

        private static IWebDriver Instance()
        {
            var options = new ChromeOptions { UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore };


            options.AddArgument("--disable-web-security");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--allow-running-insecure-content");
            options.AddArgument("--allow-insecure-localhost");

            options.AddArgument("start-maximized");

            options.AddUserProfilePreference("disable-popup-blocking", true);

            var driver = new ChromeDriver(options);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);

            return driver;
        }
    }
}