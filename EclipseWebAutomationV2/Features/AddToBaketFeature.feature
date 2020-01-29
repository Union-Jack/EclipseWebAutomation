Feature: AddToBasket
Feature file to test the job board add to basket functionality

@AddToBasketScenario1
@Candidate
@Firefox
Scenario Outline: CandidateAddToBasketScenario
	Given The user is <loggedin>
	And The jobs board is navigated to
	And The job posting on the <page> page has been navigated to  
	When The add to basket button is clicked 
	Then The job is added to the basket

Examples:
| loggedin                 | page         |
| logged in as a candidate | job board    |
| logged in as a candidate | more details |

@AddToBasketScenario2
@Firefox
Scenario Outline: AddToBasketScenario
	Given The user is <loggedin>
	And The job posting on the <page> page has been navigated to  
	When The add to basket button is clicked 
	Then The login page is loaded

Examples:
| loggedin      | page         |
| not logged in | job board    |
| not logged in | more details |