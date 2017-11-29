using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System.Linq;
using System.Collections.ObjectModel;

namespace SeleniumTests
{
    public class Example : IDisposable
    {
        private const string SearchTextBoxId = "lst-ib";
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private const string google = "https://www.google.pl/";
        //private bool acceptNextAlert = true;
        private const string TextToSearch = "codesprinters";
        private const string PageTitle = "Code Sprinters -";
        private const string LinkTextToFind = "Poznaj nasze podejście";
        private const string CookieAccept = "Akceptuję";
       

        public Example()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
         //   driver.Manage().Timeouts()
             verificationErrors = new StringBuilder();
        }



        [Fact]
        public void NavigatingToCodeSprintersSi()
        {
            GoToGoogle();

            Search(TextToSearch);
            GoToSearchResultByPageTitle();

            //// ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=@color | ]]

            var element = driver.FindElement(By.LinkText(LinkTextToFind));
            Assert.NotNull(element);
            CookieAcceptOnPage(); ;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2)); //czeka 5 sekund aż nie zniknie
            wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText("Akceptuję"), "Akceptuję"));

            waitForElementPresent(By.LinkText("Poznaj nasze podejście"), 0);

            Assert.Single(GetWebElementsLinks());

            driver.FindElement(By.LinkText("Poznaj nasze podejście")).Click();

            //System.Threading.Thread.Sleep(2);//czeka zawsze 2 sekundy



            //ver 1
            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);//wyszukiwanie tekstu na stronie

            //ver2

            Assert.Single(driver.FindElements(By.TagName("h2"))
                .Where(tag => tag.Text == "WIEDZA NA PIERWSZYM MIEJSCU"));
            //wyszukuje tagi o nazwie h2, w zwróconej kolekcji tagów wyszukuje tekstu XXX
            //single -> sprawdza czy w zwróconej kolekcji jest dokładnie 1 element

        }

        private void CookieAcceptOnPage()
        {
            driver.FindElement(By.LinkText(CookieAccept)).Click();
        }

        private ReadOnlyCollection<IWebElement> GetWebElementsLinks()
        {
            return driver.FindElements(By.LinkText(LinkTextToFind));
        }

        private void GoToSearchResultByPageTitle()
        {
            driver.FindElement(By.LinkText(PageTitle)).Click();
        }

        private void Search(string TextToSearch)
        {
            var searchBox = GetSearchBox();

            searchBox.Clear();
            searchBox.SendKeys(TextToSearch);//znajduje pierwszy element na stronie
            searchBox.Submit();
        }

        private IWebElement GetSearchBox()
        {
            return driver.FindElement(By.Id(SearchTextBoxId));
        }

        private void GoToGoogle()
        {
            driver.Navigate().GoToUrl(google);            
        }

        protected void waitForElementPresent(IWebElement by, int seconds)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            protected void waitForElementPresent(By by, int seconds)
            {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
        //Assert.Equal("Code Sprinters -", driver.Title);

        //private bool IsElementPresent(By by)
        //{
        //    try
        //    {
        //        driver.FindElement(by);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}

        //private bool IsAlertPresent()
        //{
        //    try
        //    {
        //        driver.SwitchTo().Alert();
        //        return true;
        //    }
        //    catch (NoAlertPresentException)
        //    {
        //        return false;
        //    }
        //}

        //private string CloseAlertAndGetItsText()
        //{
        //    try
        //    {
        //        IAlert alert = driver.SwitchTo().Alert();
        //        string alertText = alert.Text;
        //        if (acceptNextAlert)
        //        {
        //            alert.Accept();
        //        }
        //        else
        //        {
        //            alert.Dismiss();
        //        }
        //        return alertText;
        //    }
        //    finally
        //    {
        //        acceptNextAlert = true;
        //    }
        //}

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.Equal("", verificationErrors.ToString());
        }
        
    }
}