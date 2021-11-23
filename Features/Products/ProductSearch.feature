Feature: ProductSearch

@Search
@Products

Scenario: Success search for a product

Given I navigate to the homepage page
	When I search for the product 'Printed Summer Dress'
	Then I verify that 'Printed Summer Dress' product is displayed on the search results page