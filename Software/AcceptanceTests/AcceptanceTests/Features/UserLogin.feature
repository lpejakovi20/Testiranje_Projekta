Feature: UserLogin

As a kitchen or accounting employee
I want to be able to log in or register in to the system
So I could manage the groceries

Scenario: Login form display
	When the user launches the application
	Then the user should see the login form

Scenario: Empty credentials
	Given the user is on the login form
	When the user enters empty e-mail and password
	And the user clicks on the Login button
	Then the user should see "Pogrešna lozinka!" error message

Scenario: Succesfull kitchen employee login
	Given the kitchen employee is on the login form
	When the kitchen employee enters valid credentials for his account
	And the kitchen employee clicks on the Login button
	Then the kitchen employee should see main form for kitchen

Scenario: Succesfull accounting employee login
	Given the accounting employee is on the login form
	When the accounting employee enters valid credentials for his account
	And the accounting employee clicks on the Login button
	Then the accounting employee should see main form for accounting

Scenario: Invalid kitchen employee password
	Given the kitchen employee is on the login form
	When the kitchen employee enters username "test@mail.com" and password "krivaLozinka"
	And the kitchen employee clicks on Login button
	Then the kitchen employee should see "Pogrešna lozinka!" error message

Scenario: Kitchen employee logout
	Given  the kitchen employee is on the form "Katalog Namirnica"
	When the kitchen employee clicks Odjava button
	Then the kitchen employee should see Login form
