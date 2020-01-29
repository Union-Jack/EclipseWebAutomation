Feature: ApplyForJob
Feature file to test the job board apply for job functionality


@ApplyForJobScenario1
@Candidate
@Firefox
Scenario Outline: CandidateApplyForJob
	Given The user is <loggedin>
	And The jobs board is navigated to
	And The job posting on the <page> page has been navigated to  
	When The apply button is clicked 
	Then The job is applied for

Examples:
| loggedin                 | page         |
| logged in as a candidate | job board    |
| logged in as a candidate | more details |


@ApplyForJobScenario2
@Firefox
Scenario Outline: ApplyForJobScenario
	Given The user is <loggedin>
	And The job posting on the <page> page has been navigated to  
	When The apply button is clicked 
	Then The login page is loaded

Examples:
| loggedin      | page         |
| not logged in | job board    |
| not logged in | more details |
