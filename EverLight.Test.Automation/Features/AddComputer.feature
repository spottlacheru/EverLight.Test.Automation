Feature: AddComputer
	Test to add Computer to database


Background: User Navigate to URL

@mytag
Scenario: Add two numbers
	Given The user is on HomePage
	When The user clicks on add button
	Then The user enter mycomp in field name
	And The user enter 2010-05-22 in field introduced
	And The user enter 2019-05-22 in field discontinued
	And The user select item lstitme from list
	When The user clicks on Create Btn
	Then The user see confirmation message