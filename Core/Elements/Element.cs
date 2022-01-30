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

        public Element(IWebDriver driver, By by)
        {
            this.driver = driver;
            this.by = by;
        }

        public void Click()
        {
            driver.FindElement(by).Click();
            LogAction("Click on element");
        }

        public string Text => driver.FindElement(by).Text;

        public void LogAction(string action)
        {
            Logger.Instance.Log($"{elementType}: {action}");
        }
    }
}
