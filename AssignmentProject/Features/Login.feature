Feature: Login
	As a registered user of Giftrete
	I want to be able to log in 
	So that I can use the site
	
@mytag
Scenario: Login with valid details
	Given I navigate to the homepage
	When I click on the login link
	And I enter my registered email address
	And I enter my registered password
	And I click on the secure sign in button
	Then I am logged in
	
