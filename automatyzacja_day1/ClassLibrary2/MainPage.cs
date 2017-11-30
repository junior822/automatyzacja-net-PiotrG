using System;
using System.Linq;

namespace PageobjectsTest
{
    internal class MainPage
    {
        private static string url = "https://autotestdotnet.wordpress.com/";        
        internal static void GoTo()
        {
            Browser.NavigateTo(url);
        }

        internal static void OpenFirsNote()
        {
            var elements = Browser.FindByXpath("//article//header");
            elements.First().Click();
            
        }
    }
}