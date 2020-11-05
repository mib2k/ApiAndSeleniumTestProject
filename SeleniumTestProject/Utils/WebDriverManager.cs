using Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTestProject.Utils
{
    public class WebDriverManager
    {
        private static readonly ThreadLocal<IWebDriver> DriverPool = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                //Thread.Sleep(500);
                return DriverPool.Value ??= CreateAndGetDriver();
            }
        }
        private static IWebDriver CreateAndGetDriver()
        {
            var driverProxy = Instance();
            return driverProxy;
        }

        public static void CloseDriver()
        {
            try
            {
                if (DriverPool.IsValueCreated)
                {
                    DriverPool.Value.Close();
                    DriverPool.Value.Quit();
                    DriverPool.Value = null;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                ProcessTracker.KillProcesses("chromedriver");
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);
            return driver;
        }
    }
}