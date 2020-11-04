using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestContext;

namespace SeleniumTestProject.Utils
{
    class WebDriverUtils
    {

        public static void SaveCookieByName(string CookieName)
        {
            Cookie NamedCookie = WebDriverManager.Driver.Manage().Cookies.GetCookieNamed(CookieName);
            Context.Current.KeyValuePairs.Add(NamedCookie.Name, NamedCookie.Value);
        }
    }
}
