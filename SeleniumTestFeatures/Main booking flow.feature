Feature: Main booking flow
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given Select departure DUB and arrival LHR with type ONE_WAY
	And Select date 14 days from now
	When Click Search button
	Then FSR page is displayed

Scenario: Add two numbers2
	Given Select departure DUB and arrival LHR with type ONE_WAY
	And Select date 14 days from now
	When Click Search button
	Then FSR page is displayed