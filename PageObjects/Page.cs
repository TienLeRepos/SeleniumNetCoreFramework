using OpenQA.Selenium;

namespace DotNetFramework.PageObjects
{
    abstract class Page
    {
        protected IWebDriver _driver;

        protected Page(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(string url) => _driver.Navigate().GoToUrl(url);
    }
}