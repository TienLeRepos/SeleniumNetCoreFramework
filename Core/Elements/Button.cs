using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class Button : Element
    {
        public Button(IWebDriver driver, By by) : base(driver, by) { }

        public void Click() => driver.FindElement(by).Click();
    }
}
