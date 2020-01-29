Feature: CandidateDashboard	
Feature file to test the candidate dashboard functionality

@CandidateDashboardScenario1
@Candidate
@Firefox
Scenario Outline: OpenDashboardPages
	Given The user is <loggedin>
	When The <page> dashboard button is clicked
	Then The candidate <page> page is opened

Examples:
| loggedin                 | page             |
| logged in as a candidate | Profile          |
| logged in as a candidate | CV               |
| logged in as a candidate | Timesheets       |
| logged in as a candidate | Job Searches     |
| logged in as a candidate | Job Basket       |
| logged in as a candidate | Job Applications |
| logged in as a candidate | Change Password  |
| logged in as a candidate | Jobs Board       |

