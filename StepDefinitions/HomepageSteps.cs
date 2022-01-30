using BoDi;
using DotNetFramework.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DotNetFramework.StepDefinitions
{
    [Binding]
    public class HomepageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly HomepagePage _homepagePage;

        public HomepageSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _homepagePage = new HomepagePage(objectContainer.Resolve<IWebDriver>());
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to the homepage page")]
        public void GivenINavigateToTheHomepagePage()
        {
            _homepagePage.NavigateToHomepage();
        }

        [When(@"I click option '(.*)'")]
        public void WhenIClickOption(string optionName)
        {
            _homepagePage.ClickOption(optionName);
        }
    }
}