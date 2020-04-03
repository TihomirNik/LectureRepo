Feature: UsernameInAbvExists
	Look if the Checker for username
	works correctly

@positive
Scenario: Try to see if your user name is registerd in abv
	Given Navigate to ABV site
	When I click to new register
	And Enter "tihomir"
	And Click on Check username
	Then Message for validation
