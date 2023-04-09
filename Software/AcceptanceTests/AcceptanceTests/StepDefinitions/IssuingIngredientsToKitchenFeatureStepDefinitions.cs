using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class IssuingIngredientsToKitchenFeatureStepDefinitions
    {
        [Given(@"I am on the form for creating issuing document")]
        public void GivenIAmOnTheFormForCreatingIssuingDocument()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtEmail = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");

            txtEmail.SendKeys("test@mail.com");
            txtPassword.SendKeys("123456");
            btnLogin.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First()); //ne radi bez ovoga

            driver.SwitchTo().Window(driver.WindowHandles.First()); 
            var btnCreateIzdatnica = driver.FindElementByName("Kreiraj izdatnicu");

            btnCreateIzdatnica.Click();

            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        [When(@"I click on the button ""([^""]*)""")]
        public void WhenIClickOnTheButtonPrint(string p0)
        {
            var driver = GuiDriver.GetDriver();
            
            var btnPrint = driver.FindElementByAccessibilityId("btnIspis");
            btnPrint.Click();
            
        }

        [Then(@"I should see ""([^""]*)"" error message")]
        public void ThenIShouldSeeErrorMessage(string p0)
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            IWebElement messageBox = driver.FindElementByName(p0);

            string expectedMessage = p0;
            var message = messageBox.Text;

            var btnOK = driver.FindElementByName("U redu");
            btnOK.Click();

            try
            {
                var form = driver.FindElementByAccessibilityId("FrmDodajStavkuIzdatnice");

                if (form != null)
                {
                    var btnExit = form.FindElementByName("Zatvori");
                    btnExit.Click();
                }
            }
            catch(Exception ex)
            {

            }

            Assert.AreEqual(expectedMessage, message);
            
        }

        [When(@"I click on the ""([^""]*)"" button")]
        public void WhenIClickOnTheButtonDodaj(string dodaj)
        {
            var driver = GuiDriver.GetDriver();

            var btnAdd = driver.FindElementByAccessibilityId("btnDodaj");

            btnAdd.Click();
        }

        [Then(@"I should see a form open for adding new item")]
        public void ThenIShouldSeeAFormOpenForAddingNewItem()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());


            var form = driver.FindElementByAccessibilityId("FrmDodajStavkuIzdatnice");
            var btnExit = form.FindElementByName("Zatvori");
            btnExit.Click();

            Assert.IsNotNull(form);
        }

        [When(@"I click on the Back button")]
        public void WhenIClickOnTheBackButton()
        {
            var driver = GuiDriver.GetDriver();

            var btnBack = driver.FindElementByAccessibilityId("btnBack");

            btnBack.Click();
        }

        [Then(@"I should see a form that shows catalog of ingredients")]
        public void ThenIShouldSeeAFormThatShowsCatalogOfIngredients()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByAccessibilityId("FrmKatalogNamirnica");

            Assert.IsNotNull(form);
        }

        [Then(@"the ""([^""]*)"", ""([^""]*)"", and ""([^""]*)"" textboxes should be disabled on shown form")]
        public void ThenTheAndTextboxesShouldBeDisabledOnShownForm(string txtId, string txtNaziv, string txtVrsta)
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var txtID = driver.FindElementByAccessibilityId("txtId");
            var txtName = driver.FindElementByAccessibilityId("txtNaziv");
            var txtType = driver.FindElementByAccessibilityId("txtVrsta");

            var disabled = txtID.Enabled || txtName.Enabled || txtType.Enabled;

            var form = driver.FindElementByAccessibilityId("FrmDodajStavkuIzdatnice");
            var btnExit = form.FindElementByName("Zatvori");
            btnExit.Click();

            Assert.IsFalse(disabled);
        }

        [When(@"I click on the Add button")]
        public void WhenIClickOnTheAddButton()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByAccessibilityId("FrmDodajStavkuIzdatnice");

            var btnAdd = form.FindElementByAccessibilityId("btnDodaj");

            btnAdd.Click();
        }

        [When(@"I click on the Cancel button")]
        public void WhenIClickOnTheCancelButton()
        {
            var driver = GuiDriver.GetDriver();

            var btnCancel = driver.FindElementByAccessibilityId("btnOdustani");
            btnCancel.Click();
        }

        [Then(@"I should see form for issuing ingredients to kitchen")]
        public void ThenIShouldSeeFormForIssuingIngredientsToKitchen()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByAccessibilityId("FrmStavkeIzdatnice");

            Assert.IsNotNull(form);
        }

        [AfterScenario]
        public void CloseApplication()
        {
            GuiDriver.Dispose();
        }
    }
}
