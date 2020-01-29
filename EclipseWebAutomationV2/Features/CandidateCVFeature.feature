Feature: CandidateCV
Feature file to test the candidate CV functionality


@CandidateCVScenario1
@Firefox
Scenario: UploadCV
	Given The user is logged in as a candidate
	And The CV page has been navigated to
	When The CV is attached
	And The Upload CV button is clicked
	Then The CV is uploaded

@CandidateCVScenario2
@Firefox
Scenario: OpenCV
	Given The user is logged in as a candidate
	And The CV page has been navigated to
	When The open CV button is clicked
	Then The CV is downloaded

