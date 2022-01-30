using BoDi;
using DotNetFramework.Core;
using DotNetFramework.Utils;
using OpenQA.Selenium;
using System.Drawing;
using TechTalk.SpecFlow;
using Logger = DotNetFramework.Utils.Logger;

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
            Logger.Instance.Log(scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString() + " " + scenarioContext.StepContext.StepInfo.Text);
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDriver = Browser.InitBrowser(Configuration.BrowserName);
            if (Configuration.IsBrowserHeadless)
                webDriver.Manage().Window.Size = new Size(1920, 1080);
            else
                webDriver.Manage().Window.Maximize();
            
            objectContainer.RegisterInstanceAs(webDriver);
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            objectContainer.Resolve<IWebDriver>().Close();
            objectContainer.Resolve<IWebDriver>().Dispose();
        }

        [AfterFeature]
        public static void CloseLogger()
        {
            Logger.Instance.Close();
        }
    }
}