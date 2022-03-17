using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class RadioButton : Element
    {

        protected override string elementType => "Radio Button";

        public RadioButton(IWebDriver driver, By by, string description) : base(driver, by, description)
        {

        }

        public bool IsActive 
        {
            get 
            {
                LogAction($"Checking if radio button '{Description}' is selected");
                return driver.FindElement(by).Selected; 
            }
        }
    }
}