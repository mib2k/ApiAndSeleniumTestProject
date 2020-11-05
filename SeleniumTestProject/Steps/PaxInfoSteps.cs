using SeleniumTestProject.Pages;
namespace SeleniumTestProject.Steps
{
    class PaxInfoSteps : BaseSteps
    {
        private PassengerInfoPage _paxInfoPage => new PassengerInfoPage();

        public void FillPaxInfo()
        {
 
            _paxInfoPage.PaxTitle.SelectByText("Miss");
            _paxInfoPage.FirstNameInput.SendKeys("Jane");
            _paxInfoPage.LastNameInput.SendKeys("Doe");

            _paxInfoPage.EmailInput.SendKeys("TestMail@tests.com");
            _paxInfoPage.EmailConfirmationInput.SendKeys("TestMail@tests.com");

            _paxInfoPage.AreaCodeInput.SendKeys("11");
            _paxInfoPage.LocalNumberInput.SendKeys("123123123");

            _paxInfoPage.ContinueBtn.Click();            
        }
    }
}
