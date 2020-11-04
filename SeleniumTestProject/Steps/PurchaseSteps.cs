namespace SeleniumTestProject.Steps
{
    class PurchaseSteps : BaseSteps
    {
        PurchasePage _purchasePage => new PurchasePage();

        public void StartPurchaseChain() { 
        
            string amount  = _purchasePage.TotalAmount.Text;
        }
    }
}
