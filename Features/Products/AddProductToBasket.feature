Feature: AddProductToBasket

@Products
@Cart
Scenario: Add single product to basket

Given I navigate to the homepage page
	When I click the first available product
	And I click add to cart button on the product page
	Then I verify that product has been successfully added to cart