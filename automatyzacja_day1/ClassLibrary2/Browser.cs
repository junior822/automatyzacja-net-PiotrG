using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xunit;

namespace PageobjectsTest
{
    internal class Browser
    {
        private static IWebDriver driver;

        static Browser()
        {
            driver = new FirefoxDriver();
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

        internal static string PageSource()
        {
            return driver.PageSource;
        }

        internal static void waitForElementPresent(IWebElement by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
        internal static void WaitForElementsPresent(By by, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

    }
}