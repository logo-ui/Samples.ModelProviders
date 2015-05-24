Feature: Compliance
	In order to manage compliance records
	As a logged-in user
	I want to be able to manage the compliance records

@Integration
Scenario: Display compliance records
	Given I am an authenticated user with username 'Vasya'
	And Server returns compliance records of count 100
	And Login request succeeds
	When I open the application
	And I press the login button
	And I access the compliance screen
	Then compliance screen should display compliance records of count 100
