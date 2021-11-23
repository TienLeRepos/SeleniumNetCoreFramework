using BoDi;
using DotNetFramework.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace DotNetFramework.StepDefinitions
{
    [Binding]
    class SearchSteps
    {
        private readonly SearchResultsPage _searchResultsPage;
        private readonly SearchPage _searchPage;
        private readonly ScenarioContext _scenarioContext;
        public SearchSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _searchResultsPage = new SearchResultsPage(objectContainer.Resolve<IWebDriver>());
            _searchPage = new SearchPage(objectContainer.Resolve<IWebDriver>());
            _scenarioContext = scenarioContext;
        }

        [When(@"I search for the product '(.*)'")]
        public void WhenISearchForTheProduct(string productName)
        {
            _searchPage.SearchForAProduct(productName);
            _scenarioContext.Add(productName, productName);
        }


        [Then(@"I verify that '(.*)' product is displayed on the search results page")]
        public void ThenIVerifyThatProductIsDisplayedOnTheSearchResultsPage(string expectedProductName)
        {
            var product = _scenarioContext.Get<string>(expectedProductName);
            Assert.True(_searchResultsPage.IsProductFound(product), $"Product '{product}' has not been found.");
        }

    }
}
