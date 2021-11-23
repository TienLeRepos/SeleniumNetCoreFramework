using DotNetFramework.Core.Elements;
using OpenQA.Selenium;

namespace DotNetFramework.PageObjects
{
    class SearchPage : Page
    {
        public SearchPage(IWebDriver driver) : base(driver) { }

        private TextBox searchInput => new TextBox(_driver, By.Id("search_query_top"));

        public void SearchForAProduct(string productName)
        {
            searchInput.EnterText(productName);
            searchInput.EnterText(Keys.Enter);
        }
    }
}
