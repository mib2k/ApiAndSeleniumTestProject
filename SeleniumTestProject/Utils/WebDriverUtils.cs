using Framework;

namespace SeleniumTestProject.Utils
{
    class WebDriverUtils
    {
        public static void SaveCookieByName(string cookieName)
        {
            var namedCookie = WebDriverManager.Driver.Manage().Cookies.GetCookieNamed(cookieName);
            Context.Current.KeyValuePairs.Add(namedCookie.Name, namedCookie.Value);
        }
    }
}
