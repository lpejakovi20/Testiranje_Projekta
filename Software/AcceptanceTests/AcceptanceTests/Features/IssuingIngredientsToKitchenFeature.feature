Feature: IssuingIngredientsToKitchenFeature

As a worker in kitchen
I want to be able to issue ingredients to kitchen
So that i am able to record which ingredients have been used up and in what quantity

Scenario: Creating empty issuing document
Given I am on the form for creating issuing document
When I click on the button "Generiraj Izvještaj"
Then I should see "Nije unešena niti jedna stavka!" error message

Scenario: Opening the form for adding new item
Given I am on the form for creating issuing document
When I click on the "Dodaj" button
Then I should see a form open for adding new item

Scenario: Going back to form that shows catalog of ingredients
Given I am on the form for creating issuing document
When I click on the Back button
Then I should see a form that shows catalog of ingredients

Scenario: Disabled textboxes
Given I am on the form for creating issuing document
When I click on the "Dodaj" button
Then the "txtId", "txtNaziv", and "txtVrsta" textboxes should be disabled on shown form

Scenario: Item not scanned
Given I am on the form for creating issuing document
When I click on the "Dodaj" button
And I click on the Add button
Then I should see "Potrebno je skenirati QR kod nammirnice!" error message

Scenario: Canceling the process of adding new item
Given I am on the form for creating issuing document
When I click on the "Dodaj" button
And I click on the Cancel button
Then I should see form for issuing ingredients to kitchen