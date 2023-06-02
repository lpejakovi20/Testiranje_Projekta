Feature: NewGroceryToCatalogFeature


As a worker in the kitchen
I want to be able to add new ingredients into grocery catalog


Scenario: Empty ingredient
	Given I am on the form for adding new groceries to the catalog
	When I click on the button Spremi
	Then I should see Unesite sve podatke o novoj namirnice error message

Scenario: User tries to save a food item with missing information
    Given I am on the form for adding new groceries to the catalog
    When I enter some required information for creating a new food item, but dont fill it out fully
    And I click on the Spremi button
    Then I should see Unesite sve podatke o novoj namirnice error message
    

Scenario: User tries to save a food item without a QR code
    Given I am on the form for adding new groceries to the catalog
    When I enter all the required information for creating a new food item
    And I click on the button Spremi
    Then I should see Generirajte QR kod error message
    

Scenario: User tries to save a food item with only the QR code
  Given I am on the form for adding new groceries to the catalog
  When I click on the Generiraj QR kod button
  And I click on the Spremi button
  Then I should see Unesite sve podatke o novoj namirnice error message

Scenario: User correctly inputs a new grocery
  Given  I am on the form for adding new groceries to the catalog
  When I enter all the necessary information for the new food item
  And I click on the Generiraj QR kod button
  And I click on the button Spremi
  Then I should see Unešena nova namirnica message 

  Scenario: User quits inputing a new grocery
  Given I am on the form for adding new groceries to the catalog
    When I click on the odustani button
    Then the system closes the form for entering a new food item