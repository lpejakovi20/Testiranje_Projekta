using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class GroceryCatalogFeatureStepDefinitions
    {
        [Given(@"I am on the grocery catalog form")]
        public void GivenIAmOnTheGroceryCatalogForm()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the item Mrkva")]
        public void WhenIClickOnTheItemMrkva()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see items in the warhouse table")]
        public void ThenIShouldSeeItemsInTheWarhouseTable()
        {
            throw new PendingStepException();
        }

        [When(@"I enter Mrkva into search bar")]
        public void WhenIEnterMrkvaIntoSearchBar()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Pretraži button")]
        public void WhenIClickOnThePretraziButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should only see item with name of Mrkva in the grocery catalog")]
        public void ThenIShouldOnlySeeItemWithNameOfMrkvaInTheGroceryCatalog()
        {
            throw new PendingStepException();
        }

        [When(@"I enter K into search bar")]
        public void WhenIEnterKIntoSearchBar()
        {
            throw new PendingStepException();
        }

        [Then(@"I should only see items with the starting letter ""([^""]*)"" in the grocery catalog")]
        public void ThenIShouldOnlySeeItemsWithTheStartingLetterInTheGroceryCatalog(string k)
        {
            throw new PendingStepException();
        }

        [When(@"I don't enter anything into search bar")]
        public void WhenIDontEnterAnythingIntoSearchBar()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see all the items in the table")]
        public void ThenIShouldSeeAllTheItemsInTheTable()
        {
            throw new PendingStepException();
        }

        [When(@"I select Riba from the Filteri dropdown menu")]
        public void WhenISelectRibaFromTheFilteriDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see only items that have vrsta equals to Riba")]
        public void ThenIShouldSeeOnlyItemsThatHaveVrstaEqualsToRiba()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najkraćem roku from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajkracemRokuFromTheSortiranjaDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see items sorted by their rok_uporabe descending from the smallest number to the biggest")]
        public void ThenIShouldSeeItemsSortedByTheirRok_UporabeDescendingFromTheSmallestNumberToTheBiggest()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najdužem roku from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajduzemRokuFromTheSortiranjaDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see items sorted by their rok_uporabe descending from the biggest number to the smallest")]
        public void ThenIShouldSeeItemsSortedByTheirRok_UporabeDescendingFromTheBiggestNumberToTheSmallest()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najmanjoj cijeni from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajmanjojCijeniFromTheSortiranjaDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see items sorted by their cijena descending from the least expensive to the most expensive")]
        public void ThenIShouldSeeItemsSortedByTheirCijenaDescendingFromTheLeastExpensiveToTheMostExpensive()
        {
            throw new PendingStepException();
        }

        [When(@"I select Sortiraj po najvećoj cijeni from the Sortiranja dropdown menu")]
        public void WhenISelectSortirajPoNajvecojCijeniFromTheSortiranjaDropdownMenu()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see items sorted by their cijena descending from the most expensive to the least expensive")]
        public void ThenIShouldSeeItemsSortedByTheirCijenaDescendingFromTheMostExpensiveToTheLeastExpensive()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the Resetiraj prikaz button")]
        public void WhenIClickOnTheResetirajPrikazButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the table with grocieries reset")]
        public void ThenIShouldSeeTheTableWithGrocieriesReset()
        {
            throw new PendingStepException();
        }
    }
}
