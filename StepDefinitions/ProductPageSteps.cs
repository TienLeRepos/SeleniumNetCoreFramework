using BoDi;
using DotNetFramework.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace DotNetFramework.StepDefinitions
{
    [Binding]
    public class ProductPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ProductPage _productPage;


        public ProductPageSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _productPage = new ProductPage(objectContainer.Resolve<IWebDriver>());
            _scenarioContext = scenarioContext;
        }

        [When(@"I click add to cart button on the product page")]
        public void GivenIClickAddToCartButtonOnTheProductPage()
        {
            _productPage.ClickAddToCartButton();
        }

        [Then(@"I verify that product has been successfully added to cart")]
        public void ThenIVerifyThatProductHasBeenSuccessfullyAddedToCart()
        {
            Assert.True(_productPage.IsProductAddedToBasketLabelDisplayed());
        }
    }
}
