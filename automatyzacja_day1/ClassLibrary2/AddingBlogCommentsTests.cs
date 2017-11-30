using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PageobjectsTest

{
    public class AddingBlogCommentsTests : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            MainPage.GoTo();
            //wejdz na stronę bloga

            MainPage.OpenFirsNote();
            //otworz pierwszą notkę
            Guid g = Guid.NewGuid();
            var Comment = new Comment
            {
                Text = ("jr says: testowy komentarz dla firefoxa " + g),
                Mail = g+ "jr@zayebista.pl",
                User = "junior by jr"
            };


            NotePage.AddComment(Comment);
            //dodaj komentarz


            //sprawdz że komentarz się dodał

            //Thread.Sleep(5000);

            Assert.Contains(Comment.Text, Browser.PageSource());
        }
        public void Dispose()
        {
           Browser.Close();
        }
    }
}
