using System;
using System.Linq;
using System.Threading;

namespace PageobjectsTest
{
    internal class NotePage
    {
        internal static void AddComment(Comment testData)
        {
            var commentBox = Browser.FindelementById("comment");
            commentBox.Click();
            commentBox.SendKeys(testData.Text);

            var email = Browser.FindelementById("email");
            email.Click();
            email.SendKeys(testData.Mail);

            var nameLabel = Browser.FindByXpath("//label[@for='author']").First();
                nameLabel.Click();

            Thread.Sleep(5000);


            var name = Browser.FindelementById("name");
            name.Click();
            name.SendKeys(testData.User);
        }
    }
}