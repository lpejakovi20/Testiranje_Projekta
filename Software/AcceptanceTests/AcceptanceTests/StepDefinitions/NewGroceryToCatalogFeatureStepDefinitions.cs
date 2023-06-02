using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class NewGroceryToCatalogFeatureStepDefinitions
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

        [Then(@"I should see Unesite sve podatke o novoj namirnice error message")]
        public void ThenIShouldSeeUnesiteSvePodatkeONovojNamirniceErrorMessage()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            WindowsElement dialogBox = driver.FindElementByClassName("#32770");

            string expectedMessage = "Unesite sve podatke o novoj namirnice";
            
            var message = driver.FindElementByAccessibilityId("65535");
            

            var message1 = message.Text.ToString();
            var btnOK = driver.FindElementByName("OK");
            btnOK.Click();

            try
            {
                var form = driver.FindElementByAccessibilityId("FrmDodajNamirnicuUKatalog");

                if (form != null)
                {
                    var btnExit = form.FindElementByName("Odustani");
                    btnExit.Click();
                }
            }
            catch (Exception ex)
            {

            }

            Assert.AreEqual(expectedMessage, message1);
        }

        [Then(@"I should see Generirajte QR kod error message")]
        public void ThenIShouldSeeGenerirajteQRKodErrorMessage()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            WindowsElement dialogBox = driver.FindElementByClassName("#32770");

            string expectedMessage = "Generirajte QR kod";

            var message = driver.FindElementByAccessibilityId("65535");


            var message1 = message.Text.ToString();
            var btnOK = driver.FindElementByName("OK");
            btnOK.Click();

            try
            {
                var form = driver.FindElementByAccessibilityId("FrmDodajNamirnicuUKatalog");

                if (form != null)
                {
                    var btnExit = form.FindElementByName("Odustani");
                    btnExit.Click();
                }
            }
            catch (Exception ex)
            {

            }

            Assert.AreEqual(expectedMessage, message1);
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
            var driver = GuiDriver.GetOrCreateDriver();
            var txtNaziv = driver.FindElementByAccessibilityId("txtNaziv");
            txtNaziv.SendKeys("Trešnja");
            var cmbVrsta = driver.FindElementByAccessibilityId("cmbVrstanNamirnice");
            cmbVrsta.Click();
            cmbVrsta.SendKeys(Keys.ArrowDown);
            var txtCijena = driver.FindElementByAccessibilityId("txtCijena");
            txtCijena.SendKeys("1,20");
            var txtMinZalihe = driver.FindElementByAccessibilityId("txtMinZalihe");
            txtMinZalihe.SendKeys("3");
            var txtOptZalihe = driver.FindElementByAccessibilityId("txtOptZalihe");
            txtOptZalihe.SendKeys("5");
            var cmbMj = driver.FindElementByAccessibilityId("cmbMjJed");
            cmbMj.Click();
            cmbMj.SendKeys(Keys.ArrowDown);
            var txtRokUporabe = driver.FindElementByAccessibilityId("txtRokUporabe");
            txtRokUporabe.SendKeys("10");
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
            var driver = GuiDriver.GetOrCreateDriver();
            var txtNaziv = driver.FindElementByAccessibilityId("txtNaziv");
            txtNaziv.SendKeys("Trešnja");
            var cmbVrsta = driver.FindElementByAccessibilityId("cmbVrstanNamirnice");
            cmbVrsta.Click();
            cmbVrsta.SendKeys(Keys.ArrowDown);
            var txtCijena = driver.FindElementByAccessibilityId("txtCijena");
            txtCijena.SendKeys("1,20");
            var txtMinZalihe = driver.FindElementByAccessibilityId("txtMinZalihe");
            txtMinZalihe.SendKeys("3");
            var txtOptZalihe = driver.FindElementByAccessibilityId("txtOptZalihe");
            txtOptZalihe.SendKeys("5");
            var cmbMj = driver.FindElementByAccessibilityId("cmbMjJed");
            cmbMj.Click();
            cmbMj.SendKeys(Keys.ArrowDown);
            var txtRokUporabe = driver.FindElementByAccessibilityId("txtRokUporabe");
            txtRokUporabe.SendKeys("10");
        }

        [Then(@"I should see Unešena nova namirnica message")]
        public void ThenIShouldSeeUnesenaNovaNamirnicaMessage()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            WindowsElement dialogBox = driver.FindElementByClassName("#32770");

            string expectedMessage = "Unešena nova namirnica";

            var message = driver.FindElementByAccessibilityId("65535");


            var message1 = message.Text.ToString();
            var btnOK = driver.FindElementByName("OK");
            btnOK.Click();

            try
            {
                var form = driver.FindElementByAccessibilityId("FrmDodajNamirnicuUKatalog");

                if (form != null)
                {
                    var btnExit = form.FindElementByName("Odustani");
                    btnExit.Click();
                }
            }
            catch (Exception ex)
            {

            }

            Assert.AreEqual(expectedMessage, message1);
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
