Feature: GeneratingIzvjestajFeature

As worker in accounting
I want to be able to generate a report that has groceries nearing its live span


Scenario: User generates the report
	Given I am on the primary accounting screen
	When I click the Ističe rok button
	Then I should see the report

Scenario: User logs out of the accounting
Given I am on the primary accounting screen
When I click the Odjava button
Then I should see the Login screen
