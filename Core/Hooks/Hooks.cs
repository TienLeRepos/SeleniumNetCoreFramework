using BoDi;
using DotNetFramework.Core;
using DotNetFramework.Utils;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DotNetFramework.Hooks
{
    [Binding]
    class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private readonly ScenarioContext scenarioContext;

        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            this.objectContainer = objectContainer;
            this.scenarioContext = scenarioContext;
        }

        [AfterStep]
        public void AfterStep()
        {
            var a = scenarioContext;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDriver = Browser.InitBrowser(Configuration.BrowserName);
            webDriver.Manage().Window.Maximize();
            objectContainer.RegisterInstanceAs(webDriver);
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            objectContainer.Resolve<IWebDriver>().Close();
            objectContainer.Resolve<IWebDriver>().Dispose();
        }
    }
}