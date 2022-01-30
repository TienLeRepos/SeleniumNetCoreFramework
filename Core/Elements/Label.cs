﻿using OpenQA.Selenium;

namespace DotNetFramework.Core.Elements
{
    class Label : Element
    {

        protected override string elementType => "Label";

        public Label(IWebDriver driver, By by) : base(driver, by) 
        {

        }
    }
}
