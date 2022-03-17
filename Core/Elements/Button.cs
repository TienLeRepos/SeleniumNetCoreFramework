using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class Button : Element
    {

        protected override string elementType => "Button";

        public Button(IWebDriver driver, By by, string description) : base(driver, by, description) 
        {

        }
    }
}
