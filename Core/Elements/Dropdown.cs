using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotNetFramework.Core.Elements
{
    class Dropdown : Element
    {

        protected override string elementType => "Dropdown";
        private SelectElement _selectElement;

        public Dropdown(IWebDriver driver, By by, string description) : base(driver, by, description)
        {
            _selectElement = new SelectElement(driver.FindElement(by));
        }

        public void SelectByText(string text)
        {
            try
            {
                _selectElement.SelectByText(text);
            }
            catch (NoSuchElementException msg)
            {
                throw new System.Exception($"Dropdown: '{this.Description}' has no element '{text}'.\n" + msg);
            }
        }

        public void SelectByIndex(int index) => _selectElement.SelectByIndex(index);
        public void SelectByValue(string value) => _selectElement.SelectByValue(value);
    }
}