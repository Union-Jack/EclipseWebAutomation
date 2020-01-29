Feature: HomePage
Feature file to test the Homepage functionality

@HomePageScenario1
@Firefox
Scenario Outline: ClickLinkScenario
	Given The homepage has been navigated to
	When The homepage <link> link is clicked
	Then The <link> page is loaded

Examples:
| link      |
| Login     |
| Job Board |
