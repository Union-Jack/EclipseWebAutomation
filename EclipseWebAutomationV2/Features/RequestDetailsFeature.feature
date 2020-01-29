 Feature: RequestDetails
Feature file to test the job board request details functionality

@AddToBasketScenario1
@Firefox
Scenario Outline: RequestDetailsScenario
	Given The user is <loggedin>
	And The job posting on the <page> page has been navigated to  
	When The request details button is clicked 
	And The name <name> is entered into the name field
	And The email <email> is enterd into the email field
	And The subject <subject> is entered into the subject field
	And The message <message> is entered into the message field
	And The send button is clicked
	Then The request is sent

Examples:
| loggedin                 | page                   | name      | email                        | subject | message      |
| logged in as a candidate | candidate job board    | Jack Test | jacks@eclipse-software.co.uk | Test    | Test message |
| logged in as a candidate | candidate more details | Jack Test | jacks@eclipse-software.co.uk | Test    | Test message |
| not logged in            | job board              | Jack Test | jacks@eclipse-software.co.uk | Test    | Test message |
| not logged in            | more details           | Jack Test | jacks@eclipse-software.co.uk | Test    | Test message |  	


