Feature: Logout
	In order to exit current session 
	As a logged-in user
	I want to be able to logout from the system

@Integration
Scenario: Navigate to the login screen after the logout succeeds
	Given I am an authenticated user with username 'Vasya'
	And Logout request succeeds
	When I open the application
	And I press the login button
	And I press the logout button
	Then User returns to the login screen	
