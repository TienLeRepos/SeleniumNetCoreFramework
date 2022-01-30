Feature: Navigation

@basicNavigation
@UI

Scenario: Navigate to specific page
Given I navigate to the homepage page
	When I click option 'Elements'
	Then Displayed page title is 'Elements'

Scenario Outline: Navigate to all expected pages
Given I navigate to the homepage page
	When I click option '<element>'
	Then Displayed page title is '<expectedHeader>'

	Examples: 
	| element                 | expectedHeader          |
	| Elements                | Elements                |
	| Forms                   | Forms                   |
	| Alerts, Frame & Windows | Alerts, Frame & Windows |
	| Widgets                 | Widgets                 |
	| Interactions            | Interactions            |
	| Book Store Application  | Book Store              |
