Feature: Registration
	As a user of Giftrete
	I want to register
	So I can use the site


@mytag
Scenario: Registering as a user
	Given I navigate to homepage
	When I click on register link
	And I enter my first name
	And I enter my last name
	And I enter my email 
	And I enter my mobile number
	And I enter my password
	And I confirm my password
	And I click on sign up button
	Then I am registered 
	


