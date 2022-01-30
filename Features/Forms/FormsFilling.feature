Feature: FormsFilling

@forms
@UI
Scenario: Fill the whole form with correct data
	Given I navigate to the homepage page
		When I click option 'Forms'
			And I click 'Practice Form' link from the 'Forms' menu
			And I fill the form using the below data:
			| Field    | Value            |
			| Name     | Jan              |
			| LastName | Kowalski         |
			| Email    | test@example.com |
			| Gender   | Male             |
			| Mobile   | 0123456789       |
			| Birthday | 12.05.1990       |
			| Subjects | Commerce, Maths  |
			| Hobbies  | Sports, Music    |
			| Address  | Test address 12  |
			| State    | Haryana          |
			| City     | Karnal           |