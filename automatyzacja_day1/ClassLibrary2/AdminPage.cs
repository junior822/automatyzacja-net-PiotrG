using PageobjectsTest;
using System;
using System.Linq;

namespace ClassLibrary2
{
    internal class AdminPage
    {
        private static string url = "https://autotestdotnet.wordpress.com/wp-admin/";
        internal static void GoTo()
        {
            Browser.NavigateTo(url);
        }

        internal static void Login()
        {
            var usernameOrEmail = Browser.FindelementById("usernameOrEmail");
            usernameOrEmail.Click();
            usernameOrEmail.SendKeys("autotestdotnet@gmail.com");
        }

        internal static void Log()
        {
            var log = Browser.FindByXpath("//button[@type]").First();
            log.Click();
        }

        internal static void Password()
        {
            var password = Browser.FindelementById("password");
            password.Click();
            password.SendKeys("P@ssw0rd1");
        }
        public void Dispose()
        {
            Browser.Close();
        }

    }
}