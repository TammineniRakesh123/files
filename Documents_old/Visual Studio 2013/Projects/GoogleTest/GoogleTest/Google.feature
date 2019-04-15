Feature: Google
	Go to google search for baglore wiki

@mytag
Scenario: Add two numbers
	Given Open google in google browser
	And Search for banglore in search bar
	When I press enter
	Then the banglore wiki page should open
