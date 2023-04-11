Feature: GroceryCatalogFeature


As a worker in the kitchen
I want to be able to view, sort and filter groceries in the catalog
So that I will be able to easily view what I want


Scenario: Displaying warhouse item amounts
	Given I am on the grocery catalog form
	When I click on the item Mrkva
	Then I should see items in the warhouse table

Scenario: Searching using the search bar
Given I am on the grocery catalog form
When I enter Mrkva into search bar
And I click on the Pretraži button
Then I should only see item with name of Mrkva in the grocery catalog

Scenario: Searching the first letter of groceries
Given I am on the grocery catalog form
When I enter K into search bar
And I click on the Pretraži button
Then I should only see items with the starting letter "K" in the grocery catalog

Scenario: Empty searching
Given I am on the grocery catalog form
When I don't enter anything into search bar
And I click on the Pretraži button
Then I should see all the items in the table

Scenario: Filtering
Given I am on the grocery catalog form
When I select Riba from the Filteri dropdown menu
Then I should see only items that have vrsta equals to Riba

Scenario: Sorting by the shortest date of expiration
Given I am on the grocery catalog form
When I select Sortiraj po najkraćem roku from the Sortiranja dropdown menu
Then I should see items sorted by their rok_uporabe descending from the smallest number to the biggest

Scenario: Sorting by the longest date of expiration
Given I am on the grocery catalog form
When I select Sortiraj po najdužem roku from the Sortiranja dropdown menu
Then I should see items sorted by their rok_uporabe descending from the biggest number to the smallest

Scenario: Sorting by the cheapest groceries
Given I am on the grocery catalog form
When I select Sortiraj po najmanjoj cijeni from the Sortiranja dropdown menu
Then I should see items sorted by their cijena descending from the least expensive to the most expensive

Scenario: Sorting by the most expensive groceries
Given I am on the grocery catalog form
When I select Sortiraj po najvećoj cijeni from the Sortiranja dropdown menu
Then I should see items sorted by their cijena descending from the most expensive to the least expensive

Scenario: Reseting the grocery catalog
Given I am on the grocery catalog form
When I click on the Resetiraj prikaz button
Then I should see the table with grocieries reset
