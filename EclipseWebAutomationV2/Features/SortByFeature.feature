Feature: SortBy
Feature file to test the functionality of job board sorting.

@SortByScenario1
@Firefox
Scenario Outline: SortByLatestScenario
	Given The user is <loggedin>
	When The job board is sorted by <sorting> 
	Then The jobs are sorted by <sorting> order

Examples:
| loggedin      | sorting   |
| not logged in | Latest    |
| not logged in | StartDate |

