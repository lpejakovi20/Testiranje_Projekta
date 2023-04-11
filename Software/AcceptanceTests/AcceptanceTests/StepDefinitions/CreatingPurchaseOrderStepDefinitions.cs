using System;
using System.Linq;
using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CreatingPurchaseOrderStepDefinitions
    {

        [Given(@"I am on Login Form")]
        public void GivenIAmOnLoginForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();
        }

        [When(@"I log in as kitchen employee")]
        public void WhenILogInAsKitchenEmployee()
        {
            var driver = GuiDriver.GetDriver();
            var txtEmail = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");

            txtEmail.SendKeys("test@mail.com");
            txtPassword.SendKeys("123456");
            btnLogin.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        [When(@"I click on Kreiraj narudžbenicu button")]
        public void WhenIClickOnKreirajNarudzbenicuButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnCreateNarudzbenica = driver.FindElementByAccessibilityId("btnCreateNarudzbenica");
            btnCreateNarudzbenica.Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());

        }

        [Then(@"I should see a form Kreiraj Narudžbenicu")]
        public void ThenIShouldSeeAFormKreirajNarudzbenicu()
        {
            var driver = GuiDriver.GetDriver();
            bool isOpened = driver.FindElementByAccessibilityId("FrmKreirajNarudžbenicu") != null;
            bool isCorrectTitle = driver.Title == "Kreiraj Narudžbenicu";
            Assert.IsTrue(isOpened && isCorrectTitle);
        }



        [Given(@"I am on the form for creatin purchase orders")]
        public void GivenIAmOnTheFormForCreatinPurchaseOrders()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtEmail = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");

            txtEmail.SendKeys("test@mail.com");
            txtPassword.SendKeys("123456");
            btnLogin.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var btnCreateNarudzbenica = driver.FindElementByAccessibilityId("btnCreateNarudzbenica");
            btnCreateNarudzbenica.Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());

        }

        [When(@"I click on the Spemi button")]
        public void WhenIClickOnTheSpemiButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnSpremi = driver.FindElementByAccessibilityId("btnSpremi");
            btnSpremi.Click();
        }

        [Given(@"I am on purchase order form")]
        public void GivenIAmOnPurchaseOrderForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtEmail = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");

            txtEmail.SendKeys("test@mail.com");
            txtPassword.SendKeys("123456");
            btnLogin.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var btnCreateNarudzbenica = driver.FindElementByAccessibilityId("btnCreateNarudzbenica");
            btnCreateNarudzbenica.Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        [When(@"I select first item in datagrid")]
        public void WhenISelectFirstItemInDatagrid()
        {
            var driver = GuiDriver.GetDriver();

            var dgvNamirnice = driver.FindElementByAccessibilityId("dgvNamirnice");

            var firstItem = dgvNamirnice.FindElementByName("Row 0");
            firstItem.Click();
        }


        [When(@"I click on the Dodaj button")]
        public void WhenIClickOnTheDodajButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnDodaj = driver.FindElementByAccessibilityId("btnDodaj");
            btnDodaj.Click();
        }

        [When(@"I click Odustani button")]
        public void WhenIClickOdustaniButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnOdustani = driver.FindElementByAccessibilityId("btnOdustani");
            btnOdustani.Click();
        }

        [Then(@"I should see a form ""([^""]*)""")]
        public void ThenIShouldSeeAForm(string p0)
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());
            bool isOpened = driver.FindElementByAccessibilityId("FrmKatalogNamirnica") != null;
            bool isCorrectTitle = driver.Title == "Katalog Namirnica";
            Assert.IsTrue(isOpened && isCorrectTitle);
        }
    }
}
