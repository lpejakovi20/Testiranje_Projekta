Feature: CreatingPurchaseOrder

As a kithechen employee
I want to be able to create purchase orderd
So that I can send it to accounting

Scenario: Navigation to Creating Purchase Order
	Given I am on Login Form
	When I log in as kitchen employee
	And I click on Kreiraj narudžbenicu button
	Then I should see a form Kreiraj Narudžbenicu

Scenario: Saving empty purchase order
	Given I am on the form for creatin purchase orders
	When I click on the Spemi button
	Then I should see "Nije moguće kreirati praznu narudžbenicu!" error message

Scenario: Adding item to purchase order without amount
	Given I am on purchase order form
	When I select first item in datagrid 
	And I click on the Dodaj button
	Then I should see "Potrebno je unjeti količinu!" error message

Scenario: Quiting from creating purchase order
	Given I am on the form for creatin purchase orders
	When I click Odustani button
	Then I should see a form "Katalog Namirnica"
