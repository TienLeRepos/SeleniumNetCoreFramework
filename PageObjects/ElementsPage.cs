﻿using DotNetFramework.Core.Elements;
using OpenQA.Selenium;

namespace DotNetFramework.PageObjects
{
    class ElementsPage : Page
    {
        public ElementsPage(IWebDriver driver) : base(driver)
        {

        }

        private Label headerText => new Label(_driver, By.CssSelector("div[class='main-header']"));

        public string HeaderText => headerText.GetText();
    }
}