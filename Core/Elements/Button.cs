using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DotNetFramework.Core.Elements
{
    class Button : Element
    {

        protected override string elementType => "Button";

        public Button(IWebDriver driver, By by) : base(driver, by) 
        {

        }
    }
}
