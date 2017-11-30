using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
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

            var emailLabel = Browser.FindByXpath("//label[@for='email']").First();
            emailLabel.Click();
            var email = Browser.FindelementById("email");
            email.Click();
            email.SendKeys(testData.Mail);

            var nameLabel = Browser.FindelementById("author");
                nameLabel.Click();
            nameLabel.SendKeys(testData.User);
            

            var SubmitButton = Browser.FindelementById("comment-submit");
            SubmitButton.Click();

            //Thread.Sleep(5000);
        }


    }
}