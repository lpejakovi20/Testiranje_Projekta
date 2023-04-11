using System;
using System.Linq;
using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class UserLoginStepDefinitions
    {
        [When(@"the user launches the application")]
        public void WhenTheUserLaunchesTheApplication()
        {
            var driver = GuiDriver.GetOrCreateDriver();
        }

        [Then(@"the user should see the login form")]
        public void ThenTheUserShouldSeeTheLoginForm()
        {
            var driver = GuiDriver.GetDriver();
            bool isFormOpened = driver.FindElementByAccessibilityId("MainForm") != null;
            bool isCorrectTitle = driver.Title == "Prijava";
            Assert.IsTrue(isFormOpened && isCorrectTitle);
        }

        [Given(@"the user is on the login form")]
        public void GivenTheUserIsOnTheLoginForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();
        }

        [When(@"the user enters empty e-mail and password")]
        public void WhenTheUserEntersEmptyE_MailAndPassword()
        {
            var driver = GuiDriver.GetDriver();
            var txtUsername = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            txtUsername.SendKeys("");
            txtPassword.SendKeys("");
        }

        [When(@"the user clicks on the Login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");
            btnLogin.Click();
        }

        [Then(@"the user should see ""([^""]*)"" error message")]
        public void ThenTheUserShouldSeeErrorMessage(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var lblErrorMessage = driver.FindElementByAccessibilityId("65535");
            var actualMessage = lblErrorMessage.Text;
            Assert.AreEqual(actualMessage, p0);
        }

        [Given(@"the kitchen employee is on the login form")]
        public void GivenTheKitchenEmployeeIsOnTheLoginForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();
        }

        [When(@"the kitchen employee enters valid credentials for his account")]
        public void WhenTheKitchenEmployeeEntersValidCredentialsForHisAccount()
        {
            var driver = GuiDriver.GetDriver();
            var txtUsername = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            txtUsername.SendKeys("test@mail.com");
            txtPassword.SendKeys("123456");
        }

        [When(@"the kitchen employee clicks on the Login button")]
        public void WhenTheKitchenEmployeeClicksOnTheLoginButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");
            btnLogin.Click();
        }

        [Then(@"the kitchen employee should see main form for kitchen")]
        public void ThenTheKitchenEmployeeShouldSeeMainFormForKitchen()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());
            bool isOpened = driver.FindElementByAccessibilityId("FrmKatalogNamirnica") != null;
            bool isCorrectTitle = driver.Title == "Katalog Namirnica";
            Assert.IsTrue(isOpened && isCorrectTitle);
        }

        [Given(@"the accounting employee is on the login form")]
        public void GivenTheAccountingEmployeeIsOnTheLoginForm()
        {
            var driver = GuiDriver.GetOrCreateDriver();
        }

        [When(@"the accounting employee enters valid credentials for his account")]
        public void WhenTheAccountingEmployeeEntersValidCredentialsForHisAccount()
        {
            var driver = GuiDriver.GetDriver();
            var txtUsername = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            txtUsername.SendKeys("racun@mail.com");
            txtPassword.SendKeys("123456");
        }


        [When(@"the accounting employee clicks on the Login button")]
        public void GivenTheAccountingEmployeeClicksOnTheLoginButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");
            btnLogin.Click();
        }

        [Then(@"the accounting employee should see main form for accounting")]
        public void ThenTheAccountingEmployeeShouldSeeMainFormForAccounting()
        {
            var driver = GuiDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().Window(driver.WindowHandles.First());
            bool isOpened = driver.FindElementByAccessibilityId("FrmIzbornikRacunovodstvo") != null;
            bool isCorrectTitle = driver.Title == "Računovodstvo";
            Assert.IsTrue(isOpened && isCorrectTitle);
        }

        [When(@"the kitchen employee enters username ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenTheKitchenEmployeeEntersUsernameAndPassword(string p0, string krivaLozinka)
        {
            var driver = GuiDriver.GetDriver();
            var txtUsername = driver.FindElementByAccessibilityId("txtEmail");
            var txtPassword = driver.FindElementByAccessibilityId("txtLozinka");
            txtUsername.SendKeys(p0);
            txtPassword.SendKeys(krivaLozinka);
        }

        [When(@"the kitchen employee clicks on Login button")]
        public void WhenTheKitchenEmployeeClicksOnLoginButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnLogin = driver.FindElementByAccessibilityId("btnLogin");
            btnLogin.Click();
        }

        [Then(@"the kitchen employee should see ""([^""]*)"" error message")]
        public void ThenTheKitchenEmployeeShouldSeeErrorMessage(string p0)
        {
            var driver = GuiDriver.GetDriver();
            var lblErrorMessage = driver.FindElementByAccessibilityId("65535");
            var actualMessage = lblErrorMessage.Text;
            Assert.AreEqual(actualMessage, p0);
        }

        [Given(@"the kitchen employee is on the form ""([^""]*)""")]
        public void GivenTheKitchenEmployeeIsOnTheForm(string p0)
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
        }

        [When(@"the kitchen employee clicks Odjava button")]
        public void WhenTheKitchenEmployeeClicksOdjavaButton()
        {
            var driver = GuiDriver.GetDriver();
            var btnOdjava = driver.FindElementByAccessibilityId("btnBack");
            btnOdjava.Click();
        }

        [Then(@"the kitchen employee should see Login form")]
        public void ThenTheKitchenEmployeeShouldSeeLoginForm()
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
