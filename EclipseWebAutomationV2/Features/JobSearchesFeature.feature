Feature: JobSearches
Feature file to test the job searches functionality

@JobSearchesScenario1
@Firefox
Scenario: SearchJobsScenario
	Given The user is logged in as a candidate
	And The job searches page has been navigated to
	When The search jobs button is clicked
	Then The jobs are searched for

@JobSearchesScenario2
@Firefox
Scenario: DeleteSearchJobsScenario
	Given The user is logged in as a candidate
	And The job searches page has been navigated to
	When The delete button is clicked
	Then The job search is deleted