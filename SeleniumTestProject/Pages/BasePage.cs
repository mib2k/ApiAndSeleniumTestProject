using SeleniumExtras.PageObjects;
using SeleniumTestProject.Utils;

namespace SeleniumTestProject.Pages
{
    public class BasePage
    {
        protected BasePage()
        {
            PageFactory.InitElements(WebDriverManager.Driver, this);
        }
    }
}
