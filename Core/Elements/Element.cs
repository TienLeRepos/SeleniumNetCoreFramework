using BoDi;
using DotNetFramework.Utils;
using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    abstract class Element
    {
        protected IWebDriver driver;
        protected By by;
        protected abstract string elementType { get; }
        public By Locator => by;

        public Element(IWebDriver driver, By by)
        {
            this.driver = driver;
            this.by = by;
        }

        public void Click()
        {
            LogAction("Clicking on element");
            driver.FindElement(by).Click();
        }

        public void ClickViaJs()
        {
            LogAction("Clicking on element via JS");
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", driver.FindElement(by));
        }

        public string Text
        {
            get 
            {
                LogAction($"Getting text from element");
                return driver.FindElement(by).Text;
            }
        }

        protected void LogAction(string action)
        {
            Logger.Instance.Log($"[{elementType}]: {action}; Locator: {by}");
        }
    }
}
