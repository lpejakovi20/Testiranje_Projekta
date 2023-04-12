using AcceptanceTests.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Globalization;
using System.Linq;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class GroceryCatalogFeatureStepDefinitions
    {
        [Given(@"I am on the grocery catalog form")]
        public void GivenIAmOnTheGroceryCatalogForm()
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
        }

        [When(@"I click on the item Mrkva")]
        public void WhenIClickOnTheItemMrkva()
        {
            var driver = GuiDriver.GetOrCreateDriver();

            var dgvNamirnice = driver.FindElementByAccessibilityId("dgvKatalogNamirnica");

            var firstItem = dgvNamirnice.FindElementByName("Row 0");
            firstItem.Click();

        }

        [Then(@"I should see items in the warhouse table")]
        public void ThenIShouldSeeItemsInTheWarhouseTable()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var doljni = driver.FindElementByAccessibilityId("dgvNamirniceUSkladistu");
            var red = doljni.FindElementByName("Row 0");
            Assert.IsNotNull(red);
        }

        [When(@"I enter Mrkva into search bar")]
        public void WhenIEnterMrkvaIntoSearchBar()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtSearch = driver.FindElementByAccessibilityId("txtSearch");
            txtSearch.SendKeys("Mrkva");
        }

        [When(@"I click on the Pretraži button")]
        public void WhenIClickOnThePretraziButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var btnSearch = driver.FindElementByAccessibilityId("btnSearch");
            btnSearch.Click();
        }

        [Then(@"I should only see item with name of Mrkva in the grocery catalog")]
        public void ThenIShouldOnlySeeItemWithNameOfMrkvaInTheGroceryCatalog()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var dgvNamirnice = driver.FindElementByAccessibilityId("dgvKatalogNamirnica");
            var firstItem = dgvNamirnice.FindElementByName("Row 0");
            Assert.IsNotNull(firstItem);

        }

        [When(@"I enter K into search bar")]
        public void WhenIEnterKIntoSearchBar()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtSearch = driver.FindElementByAccessibilityId("txtSearch");
            txtSearch.SendKeys("K");
        }

        [Then(@"I should only see items with the starting letter ""([^""]*)"" in the grocery catalog")]
        public void ThenIShouldOnlySeeItemsWithTheStartingLetterInTheGroceryCatalog(string k)
        {
            throw new PendingStepException();
        }

        [When(@"I don't enter anything into search bar")]
        public void WhenIDontEnterAnythingIntoSearchBar()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var txtSearch = driver.FindElementByAccessibilityId("txtSearch");
            txtSearch.Click();
        }

        [Then(@"I should see all the items in the table")]
        public void ThenIShouldSeeAllTheItemsInTheTable()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var dgvNamirnice = driver.FindElementByAccessibilityId("dgvKatalogNamirnica");

            var Item = dgvNamirnice.FindElementByName("Row 20");
            Assert.IsNotNull(Item);
        }

        [When(@"I select Riba from the Filteri dropdown menu")]
        public void WhenISelectRibaFromTheFilteriDropdownMenu()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var filteri = driver.FindElementByAccessibilityId("cmbFilters");
            filteri.Click();
            filteri.SendKeys(Keys.ArrowDown);
            filteri.SendKeys(Keys.ArrowDown);
            filteri.SendKeys(Keys.ArrowDown);

        }

        [Then(@"I should see only items that have vrsta equals to Riba")]
        public void ThenIShouldSeeOnlyItemsThatHaveVrstaEqualsToRiba()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var dgvNamirnice = driver.FindElementByAccessibilityId("dgvKatalogNamirnica");

            var Item = dgvNamirnice.FindElementByName("Row 1");
            Assert.IsNotNull(Item);
        }

        [When(@"I select Sortiraj po najkraćem roku from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajkracemRokuFromTheSortiranjaDropdownMenu()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var cmbSort = driver.FindElementByAccessibilityId("cmbSort");
            cmbSort.Click();
            cmbSort.SendKeys(Keys.ArrowDown);
        }

        [Then(@"I should see items sorted by their rok_uporabe descending from the smallest number to the biggest")]
        public void ThenIShouldSeeItemsSortedByTheirRok_UporabeDescendingFromTheSmallestNumberToTheBiggest()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najdužem roku from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajduzemRokuFromTheSortiranjaDropdownMenu()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var cmbSort = driver.FindElementByAccessibilityId("cmbSort");
            cmbSort.Click();
            cmbSort.SendKeys(Keys.ArrowDown);
            cmbSort.SendKeys(Keys.ArrowDown);
        }

        [Then(@"I should see items sorted by their rok_uporabe descending from the biggest number to the smallest")]
        public void ThenIShouldSeeItemsSortedByTheirRok_UporabeDescendingFromTheBiggestNumberToTheSmallest()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najmanjoj cijeni from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajmanjojCijeniFromTheSortiranjaDropdownMenu()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var cmbSort = driver.FindElementByAccessibilityId("cmbSort");
            cmbSort.Click();
            cmbSort.SendKeys(Keys.ArrowDown);
            cmbSort.SendKeys(Keys.ArrowDown);
            cmbSort.SendKeys(Keys.ArrowDown);
        }

        [Then(@"I should see items sorted by their cijena descending from the least expensive to the most expensive")]
        public void ThenIShouldSeeItemsSortedByTheirCijenaDescendingFromTheLeastExpensiveToTheMostExpensive()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najvećoj cijeni from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajvecojCijeniFromTheSortiranjaDropdownMenu()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var cmbSort = driver.FindElementByAccessibilityId("cmbSort");
            cmbSort.Click();
            cmbSort.SendKeys(Keys.ArrowDown);
            cmbSort.SendKeys(Keys.ArrowDown);
            cmbSort.SendKeys(Keys.ArrowDown);
            cmbSort.SendKeys(Keys.ArrowDown);
        }

        [Then(@"I should see items sorted by their cijena descending from the most expensive to the least expensive")]
        public void ThenIShouldSeeItemsSortedByTheirCijenaDescendingFromTheMostExpensiveToTheLeastExpensive()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Resetiraj prikaz button")]
        public void WhenIClickOnTheResetirajPrikazButton()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            
            var btnObrisiPrikaz = driver.FindElementByAccessibilityId("btnObrisiPrikaz");
            btnObrisiPrikaz.Click();
            

        }

        [Then(@"I should see the table with grocieries reset")]
        public void ThenIShouldSeeTheTableWithGrocieriesReset()
        {
            var driver = GuiDriver.GetOrCreateDriver();
            var dgvNamirnice = driver.FindElementByAccessibilityId("dgvKatalogNamirnica");
            var Item = dgvNamirnice.FindElementByName("Row 20");
            Assert.IsNotNull(Item);
        }
    }
}
