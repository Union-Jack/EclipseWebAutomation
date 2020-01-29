Feature: JobApplications
Feature file to test the job searches functionality

@JobApplicationsScenario1
@Firefox
Scenario:DeleteApplicationScenario
	Given The user is logged in as a candidate
	Given The job applications has been navigated to
	When The delete application button is clicked
	Then The job application is deleted
