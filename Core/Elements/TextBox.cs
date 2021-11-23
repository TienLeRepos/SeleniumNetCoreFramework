using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class TextBox : Element
    {
        public TextBox(IWebDriver driver, By by) : base(driver, by) { }

        public void EnterText(string text) => driver.FindElement(by).SendKeys(text);
    }
}
