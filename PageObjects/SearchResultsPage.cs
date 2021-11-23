using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace DotNetFramework.PageObjects
{
    class SearchResultsPage : Page
    {
        public SearchResultsPage(IWebDriver driver) : base(driver) { }

        private List<IWebElement> foundProductsList => _driver.FindElements(By.CssSelector("h5[itemprop='name'] a")).ToList();

        public bool IsProductFound(string productName) => foundProductsList.Any(x => x.Text.Equals(productName));
    }
}
