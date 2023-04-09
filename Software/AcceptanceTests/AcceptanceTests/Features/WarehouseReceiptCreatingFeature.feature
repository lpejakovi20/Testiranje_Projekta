Feature: WarehouseReceiptCreatingFeature

As a worker in accounting
I want to be able to create warehouse receipt
So that new ingredients can be added to warehouse

Scenario: Opening a purchasing order
Given I am on the form that shows all purchase orders
When I select the first purchase order
And I click the button for opening the order
Then I should see all items that belong to that order

Scenario: Returning back to form with purchasing orders
Given I am on the form that shows all purchase orders
When I select the first purchase order
And I click the button for opening the order
And I click the button for going back to form that shows all purchasing orders
Then I should see the form that that shows all purchasing orders

Scenario: Creating warehouse receipt
Given I am on the form that shows all purchase orders
When I select the first purchase order
And I click the button for opening the order
And I click the button for creating the warehouse receipt
Then I should see the form that displays the warehouse receipt