Feature: TMFeature
	As a TurnUp portal admin
	I would like to create, edit and delete time and material records
	So that I can manage employees time and materials successfully

@tmtest @regression @one
Scenario: 01 create time and material record with valid details
	Given I logged into turn up portal successfully
	And I navigate to time and material page
	When I create time and material record
	Then the record should be created successfully


@tmtest @regression @two
Scenario Outline: 02 edit time and material record with valid details
	Given I logged into turn up portal successfully
	And I navigate to time and material page
	When I update '<Description>' '<TypeCode>' on an existing time and material record
	Then the record should have the updated '<Description>'

	Examples: 
	| Description | TypeCode |
	| apple       | T        |
	| 123         | M        |
