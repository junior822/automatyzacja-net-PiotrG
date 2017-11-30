using OpenQA.Selenium;
using PageobjectsTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary2
{
    public class AddingAdminBlogComment : IDisposable
    {
        [Fact]
        public void LoginAdminPage()
        {
            AdminPage.GoTo();
            AdminPage.Login();
            AdminPage.Password();
            AdminPage.Log();
            
            Browser.WaitForElementsPresent(By.LinkText("Posts"), 3);

            Assert.Contains("Posts", Browser.PageSource());

            PostsPage.AssertPage();
            PostsPage.Posts();
            PostsPage.AddNewPosts();
            Thread.Sleep(5000);
            PostsPage.EditPosts();
            PostsPage.PublishPost();
            Thread.Sleep(5000);
            PostsPage.LogOut();
            Thread.Sleep(5000);
            AdminPage.GoTo();
            AdminPage.Login();
            AdminPage.Password();
            AdminPage.Log();

            Browser.WaitForElementsPresent(By.LinkText("Posts"), 3);
        }
        public void Dispose()
        {
            Browser.Close();
        }
    }
}
