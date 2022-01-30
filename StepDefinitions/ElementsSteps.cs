using BoDi;
using DotNetFramework.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace DotNetFramework.StepDefinitions
{
    [Binding]


    class ElementsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ElementsPage _elementsPage;

        public ElementsSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _elementsPage = new ElementsPage(objectContainer.Resolve<IWebDriver>());
        }

        [Then(@"Displayed page title is '(.*)'")]
        public void ThenDisplayedPageTitleIs(string expectedText)
        {
            Assert.True(_elementsPage.HeaderText.Equals(expectedText),
                $"Page title is not as expected.\nActual: {_elementsPage.HeaderText}\nExpected: {expectedText}");
        }
    }
}
