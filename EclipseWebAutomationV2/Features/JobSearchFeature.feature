Feature: JobSearch
Feature file to test the login Validation and login to the web application.


@JobSearchScenario1
@Firefox
Scenario Outline: JobSearchScenario
	Given The user is <loggin>
	When I enter <keyword> into the keywords field
	And I select a <country> into the country field
	And I select a <region> into the region field
	And I select a <location> into the location field
	And I select a <industry> into the industry field
	And I select a <discipline> into the discipline field
	And I click go
	Then The jobs board is loaded

Examples:
| loggin                   | keyword | country        | region             | location   | industry | discipline |
| logged in as a candidate | Surgeon | United Kingdom | Greater Manchester | Manchester | Medical  | Surgeon    |
| logged in as a client    | Surgeon | United Kingdom | Greater Manchester | Manchester | Medical  | Surgeon    |
| not logged in            | Surgeon | United Kingdom | Greater Manchester | Manchester | Medical  | Surgeon    |








