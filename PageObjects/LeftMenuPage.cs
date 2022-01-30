using DotNetFramework.Core.Elements;
using OpenQA.Selenium;

namespace DotNetFramework.PageObjects
{
    class LeftMenuPage : Page
    {
        public LeftMenuPage(IWebDriver driver) : base(driver) { }

        private Button LeftMenuLink(string section, int optionIndex) => new Button(_driver, By.XPath($"//div[text()='{section}']/ancestor::div[@class='element-group']//li[@id='item-{optionIndex}']"));

        public void ClickMenuLink(string section, int optionIndex) => LeftMenuLink(section, optionIndex).Click();
    }
}
