﻿using SeleniumTestProject.ElementExtensions;
using SeleniumTestProject.Pages;

namespace SeleniumTestProject.Steps
{
    class TravelExtrasSteps : BaseSteps
    {
        TravelExtrasPage _travelExtrasPage => new TravelExtrasPage();

        public void ClickContinueBtn()
        {
            _travelExtrasPage.ContinueBtn.WaitForClickable(60);
            _travelExtrasPage.ContinueBtn.Click();
        }
    }
}
