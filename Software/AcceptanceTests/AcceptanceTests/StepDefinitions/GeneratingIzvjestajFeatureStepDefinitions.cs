using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class GeneratingIzvjestajFeatureStepDefinitions
    {
        [Given(@"I am on the primary accounting screen")]
        public void GivenIAmOnThePrimaryAccountingScreen()
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
        }

        [When(@"I click the Ističe rok button")]
        public void WhenIClickTheIsticeRokButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnIstice = driver.FindElementByAccessibilityId("button2");
            btnIstice.Click();
        }

        [Then(@"I should see the report")]
        public void ThenIShouldSeeTheReport()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            var form = driver.FindElementByAccessibilityId("FrmIzvjestajBlizuRok");
            Assert.IsNotNull(form);

        }

        [When(@"I click the Odjava button")]
        public void WhenIClickTheOdjavaButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnOdjava = driver.FindElementByAccessibilityId("btnBack");
            btnOdjava.Click();
        }

        [Then(@"I should see the Login screen")]
        public void ThenIShouldSeeTheLoginScreen()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());
            bool isOpened = driver.FindElementByAccessibilityId("MainForm") != null;
            bool isCorrectTitle = driver.Title == "Prijava";
            Assert.IsTrue(isOpened && isCorrectTitle);
        }
    }
}
