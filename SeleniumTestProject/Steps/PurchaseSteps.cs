using SeleniumTestProject.Pages;

namespace SeleniumTestProject.Steps
{
    class PurchaseSteps : BaseSteps
    {
        PurchasePage _purchasePage => new PurchasePage();

        public void StartPurchaseChain() { 
        
            var amount  = _purchasePage.TotalAmount.Text;
        }
    }
}
