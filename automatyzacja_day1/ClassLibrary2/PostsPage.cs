using PageobjectsTest;
using System;
using System.Linq;
using System.Threading;
using Xunit;

namespace ClassLibrary2
{
    internal class PostsPage
    {
        internal static void AssertPage()
        {
            Assert.Contains("Add New", Browser.PageSource());
        }

        internal static void AddNewPosts()
        {
            
            var NewPost = Browser.FindByXpath("//*[@id='wpbody-content']/div[3]/a").Single();
            NewPost.Click();
        }

        internal static void EditPosts()
        {
            var PostTitle = Browser.FindelementById("title-prompt-text");
            PostTitle.Click();
            PostTitle.SendKeys("badzia badzia badzia by jr");

            var PostText = Browser.FindByXpath("//*[@id='content']").Single();
            PostText.Click();
            PostText.SendKeys("badzia badzia badzia by jr badzia badzia badzia by jr badzia badzia badzia by jr badzia badzia badzia by jr badzia badzia badzia by jr");


        }

        internal static void LogOut()
        {
            var avatar = Browser.FindByXpath("//*[@id='wp-admin-bar-my-account']/a").Single();
            avatar.Click();
            var LogOut = Browser.FindByXpath("//button[text()='Sign Out']").Single();
            LogOut.Click();
        }

        internal static void PublishPost()
        {
            var pustyklick = Browser.FindelementById("content-html");
            pustyklick.Click();
            Thread.Sleep(3000);
            var Publish = Browser.FindelementById("publish");
            Publish.Click();
        }

        internal static void Posts()
        {
            var Posts = Browser.FindByXpath("//*[@id='menu-posts']/a/div[3]").Single();
            Posts.Click();

        }
    }
}