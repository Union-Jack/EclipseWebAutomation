Feature: SaveJobSearch
Feature file to test the functionality of saving a job search.

@SaveJobSearchScenario1
@Firefox
Scenario: CandidateSaveJobSearchScenario
	Given The user is logged in as a candidate
	And The job criteria has been searched for
	When The save search button is clicked
	Then The save jobs search page is displayed
	And A name is entered
	And The save button is clicked
	Then The job searches page is displayed
	And The job search will be saved



@SaveJobSearchScenario2
@Firefox
Scenario: ClientSaveJobSearchScenario
	Given The user is logged in as a client
	And The job criteria has been searched for
	When The save search button is clicked
	Then The save jobs search page is displayed
	And The user is asked to log in as a candidate


@SaveJobSearchScenario3
@Firefox
Scenario: SaveJobSearchValidationScenario
	Given The homepage has been navigated to
	And The job criteria has been searched for
	When The save search button is clicked
	Then The login page is loaded
