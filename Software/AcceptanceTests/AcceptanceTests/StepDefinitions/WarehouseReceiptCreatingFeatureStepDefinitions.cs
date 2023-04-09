using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class WarehouseReceiptCreatingFeatureStepDefinitions
    {
        [Given(@"I am on the form that shows all purchase orders")]
        public void GivenIAmOnTheFormThatShowsAllPurchaseOrders()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtEmail = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");

            txtEmail.SendKeys("racun@mail.com");
            txtPassword.SendKeys("123456");
            btnLogin.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First()); //ne radi bez ovoga

            driver.SwitchTo().Window(driver.WindowHandles.First());
            var btnViewPurchaseOrders = driver.FindElementByAccessibilityId("btnPregledNarudzbenica");

            btnViewPurchaseOrders.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        [When(@"I select the first purchase order")]
        public void WhenISelectTheFirstPurchaseOrder()
        {
            var driver = GuiDriver.GetDriver();

            var dgvPurchaseOrders = driver.FindElementByAccessibilityId("dgvNarudzbenice");

            var firstItem = dgvPurchaseOrders.FindElementByName("Row 0");
            firstItem.Click();
        }

        [When(@"I click the button for opening the order")]
        public void WhenIClickTheButtonForOpeningTheOrder()
        {
            var driver = GuiDriver.GetDriver();

            var btnOpen = driver.FindElementByAccessibilityId("btnOtvori");
            btnOpen.Click();
        }

        [Then(@"I should see all items that belong to that order")]
        public void ThenIShouldSeeAllItemsThatBelongToThatOrder()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByAccessibilityId("FrmStavkeNarudzbenice");

            Assert.IsNotNull(form);
        }

        [When(@"I click the button for going back to form that shows all purchasing orders")]
        public void WhenIClickTheButtonForGoingBackToFormThatShowsAllPurchasingOrders()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            var btnBack = driver.FindElementByAccessibilityId("btnBack");
            btnBack.Click();
        }

        [Then(@"I should see the form that that shows all purchasing orders")]
        public void ThenIShouldSeeTheFormThatThatShowsAllPurchasingOrders()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByName("Narudžbenice");

            Assert.IsNotNull(form);
        }

        [When(@"I click the button for creating the warehouse receipt")]
        public void WhenIClickTheButtonForCreatingTheWarehouseReceipt()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            var btnBack = driver.FindElementByAccessibilityId("btnIzradiPrimku");
            btnBack.Click();
        }

        [Then(@"I should see the form that displays the warehouse receipt")]
        public void ThenIShouldSeeTheFormThatDisplaysTheWarehouseReceipt()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByAccessibilityId("FrmIzvjestajPrimka");
            var btnExit = form.FindElementByName("Zatvori");
            btnExit.Click();


            Assert.IsNotNull(form);
        }

    }
}
