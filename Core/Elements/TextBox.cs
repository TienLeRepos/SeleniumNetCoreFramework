using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class TextBox : Element
    {
        public TextBox(IWebDriver driver, By by) : base(driver, by) { }

        protected override string elementType => "TextBox";

        public void EnterText(string text)
        {
            LogAction($"Entering text: '{text}'");
            driver.FindElement(by).SendKeys(text);
        }

        public void SelectAllTextAndEnterNewText(string text)
        {
            LogAction("Selecting all text from input");
            driver.FindElement(by).SendKeys(Keys.Control + "a");
            LogAction($"Entering text: '{text}'");
            driver.FindElement(by).SendKeys(text);
            LogAction("Hitting 'Enter' button");
            driver.FindElement(by).SendKeys(Keys.Enter);
        }

        public void EnterTextAndHitEnter(string text)
        {
            LogAction($"Entering text: '{text}'");
            driver.FindElement(by).SendKeys(text);
            LogAction("Hitting 'Enter' button");
            driver.FindElement(by).SendKeys(Keys.Enter);
        }
    }
}
