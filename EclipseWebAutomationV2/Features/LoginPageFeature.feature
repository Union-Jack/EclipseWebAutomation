Feature: LoginPage
Feature file to test the login Validation and login to the web application.

@LoginPageScenario1
@Firefox
Scenario Outline: ValidLoginScenario
	Given The login page has been navigated to
	When The <username>, <password> and <accounttype> are entered
	And The login button is clicked
	Then The access page is displayed
	And The <accounttype> dashboard is loaded

Examples:
| username                            | password    | accounttype |
| liamknowles                         | liamknowles | candidate   |
| tickleclient@eclipse-software.co.uk | 12345       | client      |

@LoginPageScenario2
@Firefox
Scenario Outline: InvalidLoginScenario
	Given The login page has been navigated to
	When The <username>, <password> and <accounttype> are entered
	And The login button is clicked
	Then The access page is displayed
	And The login error is displayed

Examples:
| username                            | password    | accounttype |
| jack                                | liamknowles | candidate   |
| liamknowles                         | 12345       | client      |
| tickleclient@eclipse-software.co.uk | 12345       | candidate   |