Feature: Example

Scenario Outline: Add Numbers Outline
	When I add <Number1> to <Number2>
	Then the result is <Result>
	Examples:
	| Number1 | Number2 | Result |
	| 4       | 4       | 8      |
	| 2       | 2       | 4      |


Scenario: Add Numbers Table
	When I add the follwing numbers
	| attribute | value |
	| Number 1  | 3     |
	| Number 2  | 3     |
	Then the total is always correct
	
