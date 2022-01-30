using DotNetFramework.Core.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotNetFramework.PageObjects
{
    class ProductPage : Page
    {
        public ProductPage(IWebDriver driver) : base(driver) { }

        private Button addToCartBtn => new Button(_driver, By.Id("add_to_cart"));

        private IWebElement addToCartSuccessLabel => _driver.FindElement(By.XPath("(//div[@id='layer_cart']//h2)[1]"));

        public void ClickAddToCartButton() => addToCartBtn.Click();
        public bool IsProductAddedToBasketLabelDisplayed()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            return wait.Until(drv => addToCartSuccessLabel.Displayed);
        }
    }
}
