using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace PageobjectsTest
{
    internal class Browser
    {
        private static IWebDriver driver;

        static Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

        internal static ReadOnlyCollection<IWebElement> FindByXpath(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }



        internal static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        internal static void Close()
        {
            driver.Quit();
        }

        internal static IWebElement FindelementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }
    }
}