Feature: JobBasket
Feature file to test the job searches functionality

@JobBasksetScenario1
@Firefox
Scenario: ApplyFromBasketScenario
	Given The user is logged in as a candidate
	Given The job basket page has been navigated to
	When The apply button is clicked
	Then The job is applied for

@JobBasksetScenario2
@Firefox
Scenario: RemoveFromBasketScenario
	Given The user is logged in as a candidate
	Given The job basket page has been navigated to
	When The remove button is clicked
	Then The item is deleted