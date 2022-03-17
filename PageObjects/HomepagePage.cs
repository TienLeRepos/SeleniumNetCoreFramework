using DotNetFramework.Core;
using DotNetFramework.Core.Elements;
using OpenQA.Selenium;

namespace DotNetFramework.PageObjects
{
    class HomepagePage : Page
    {
        
        public HomepagePage(IWebDriver driver) : base(driver)
        {
        }

        private Button Option(string optionName) => new Button(_driver, By.XPath($"//div[@class='card-body'][./h5[text()='{optionName}']]"), $"Button {optionName}");

        public void ClickOption(string optionName) => Option(optionName).Click();

        public void NavigateToHomepage() => _driver.Navigate().GoToUrl(Configuration.BaseUrl);
    }
}