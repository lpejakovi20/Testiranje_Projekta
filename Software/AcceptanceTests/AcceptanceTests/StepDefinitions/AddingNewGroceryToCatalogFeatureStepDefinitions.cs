using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class AddingNewGroceryToCatalogFeatureStepDefinitions
    {
        [Given(@"I am on the form for adding new groceries to the catalog")]
        public void GivenIAmOnTheFormForAddingNewGroceriesToTheCatalog()
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

            var btnAddNewGrocery = driver.FindElementByAccessibilityId("btnAddNewNamirnica");

            btnAddNewGrocery.Click();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        [When(@"I click on the button Spremi")]
        public void WhenIClickOnTheButtonSpremi()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnSave = driver.FindElementByAccessibilityId("btnSave");
            btnSave.Click();
        }



        [When(@"I enter some required information for creating a new food item, but dont fill it out fully")]
        public void WhenIEnterSomeRequiredInformationForCreatingANewFoodItemButDontFillItOutFully()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtNaziv = driver.FindElementByAccessibilityId("txtNaziv");
            txtNaziv.SendKeys("Trešnja");
        }

        [When(@"I click on the Spremi button")]
        public void WhenIClickOnTheSpremiButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnSave = driver.FindElementByAccessibilityId("btnSave");
            btnSave.Click();
        }

        [When(@"I enter all the required information for creating a new food item")]
        public void WhenIEnterAllTheRequiredInformationForCreatingANewFoodItem()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see Generirajte QR kod error message")]
        public void ThenIShouldSeeGenerirajteQRKodErrorMessage(string p0)
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            IWebElement messageBox = driver.FindElementByName(p0);

            string expectedMessage = p0;
            var message = messageBox.Text;

            var btnOK = driver.FindElementByName("OK");
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
            catch (Exception ex)
            {

            }

            Assert.AreEqual(expectedMessage, message);
        }

        [Then(@"I should see Unesite sve podatke o novoj namirnice error message")]
        public void ThenIShouldSeeUnesiteSvePodatkeONovojNamirniceErrorMessage(string p0)
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            IWebElement messageBox = driver.FindElementByName(p0);

            string expectedMessage = p0;
            var message = messageBox.Text;

            var btnOK = driver.FindElementByAccessibilityId("2");
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
            catch (Exception ex)
            {

            }

            Assert.AreEqual(expectedMessage, message);
        }


        [When(@"I click on the Generiraj QR kod button")]
        public void WhenIClickOnTheGenerirajQRKodButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnGenerate = driver.FindElementByAccessibilityId("btnGenerateQR");
            btnGenerate.Click();
        }

        [When(@"I enter all the necessary information for the new food item")]
        public void WhenIEnterAllTheNecessaryInformationForTheNewFoodItem()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see Unešena nova namirnica message")]
        public void ThenIShouldSeeUnesenaNovaNamirnicaMessage()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the odustani button")]
        public void WhenIClickOnTheOdustaniButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnQuit = driver.FindElementByAccessibilityId("btnOdustani");
            btnQuit.Click();
        }

        [Then(@"the system closes the form for entering a new food item")]
        public void ThenTheSystemClosesTheFormForEnteringANewFoodItem()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());

            var form = driver.FindElementByAccessibilityId("FrmKatalogNamirnica");

            Assert.IsNotNull(form);
        }
    }
}
