using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DotNetFramework.Core
{
    class Browser
    {
        private static IWebDriver driver;

        public static IWebDriver InitBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    if (IsBrowserHeadless)
                    {
                        chromeOptions.AddArgument("headless");
                    }
                    driver = new ChromeDriver(chromeOptions);
                    break;
            }

            return driver;
        }

        public static bool IsBrowserHeadless => Configuration.IsBrowserHeadless;
    }
}