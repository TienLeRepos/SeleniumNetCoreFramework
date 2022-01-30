using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class RadioButton : Element
    {

        protected override string elementType => "Radio Button";

        public RadioButton(IWebDriver driver, By by) : base(driver, by)
        {

        }

        public bool IsActive 
        {
            get 
            {
                LogAction("Checking if radio button is selected");
                return driver.FindElement(by).Selected; 
            }
        }
    }
}
