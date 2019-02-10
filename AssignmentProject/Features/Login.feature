Feature: Login
	As a registered user of Giftrete
	I want to be able to log in 
	So that I can use the site
	
@mytag
Scenario: Login with valid details
	Given I navigate to the homepage
	And I click on the login link
	And I am on the login page
	When I enter my valid email address
	And I enter my corresponding valid password
	And I click on the secure sign in button
	Then I am logged in
	And my account page is displayed
