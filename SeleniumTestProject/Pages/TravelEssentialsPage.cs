using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTestProject.Pages
{
    class TravelEssentialsPage : BasePage
    {
        public TravelEssentialsPage() : base() { }
        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_continue_btn_bags']")]
        public IWebElement ContinueBtn { get; private set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-test-id='test_bag-nag-no-sh-bags_modals_cancel_btn']")]
        public IWebElement ConfirmNoBags { get; private set; }
    }
}
