Feature: Registration
	As a user of Giftrete
	I want to register
	So I can use the site


@mytag
Scenario: Registering as a user
	Given I navigate to the homepage
	And I click on the register link
	And I am on the registration page
	When I enter my first name
	And I enter my last name
	And I enter my email "test@giftrete.com"
	And I enter my mobile number
	And I enter my password
	And I confirm my password
	And I click on the captcha box
	And I click on the sign up button
	Then I am registered 
	And a thank you message is displayed


