Feature: LogIn
	As a registerd user,
	I want to log in in sucsesfuly

@positive
Scenario: LohIn in web scraper website
	Given I navigate to web Scraper homepage
	When I enter my "admin" in username field
	And I enter my "12345" in password field
	And I Click on login button
	Then  I should see Welcome message
