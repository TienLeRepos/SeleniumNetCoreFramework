using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    abstract class Element
    {
        protected IWebDriver driver;
        protected By by;

        public Element(IWebDriver driver, By by)
        {
            this.driver = driver;
            this.by = by;
        }

        public string Text => driver.FindElement(by).Text;
    }
}
