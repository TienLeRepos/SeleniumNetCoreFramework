using DotNetFramework.Core;
using OpenQA.Selenium;

namespace DotNetFramework.PageObjects
{
    class HomepagePage : Page
    {
        
        public HomepagePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement firstAvailableProduct => _driver.FindElement(By.XPath("(//div[@class='product-container'])[1]"));

        public void ClickFirstAvailableProduct() => firstAvailableProduct.Click();

        public void NavigateToHomepage() => _driver.Navigate().GoToUrl(Configuration.BaseUrl);
    }
}