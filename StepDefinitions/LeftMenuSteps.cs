using BoDi;
using DotNetFramework.PageObjects;
using DotNetFramework.PageObjects.FormsPageObjects;
using DotNetFramework.Utils;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace DotNetFramework.StepDefinitions
{
    [Binding]


    class LeftMenuSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly LeftMenuPage _leftMenuPage;

        public LeftMenuSteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _leftMenuPage = new LeftMenuPage(objectContainer.Resolve<IWebDriver>());
        }

        [When(@"I click '(.*)' link from the '(.*)' menu")]
        public void WhenIClickLinkFromTheMenu(string link, string section)
        {
            switch (section)
            {
                case "Forms":
                    _leftMenuPage.ClickMenuLink(section, Helpers.GetEnumFromDescription(link, typeof(FormsMenu)));
                    break;
            }
        }
    }
}
