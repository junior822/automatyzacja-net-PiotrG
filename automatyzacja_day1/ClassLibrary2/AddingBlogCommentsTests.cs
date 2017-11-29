using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            NotePage.AddComment(new Comment
            {
                Text = "cos tam 1",
                Mail = "test@cośtam.pl",
                User = "coś tam 3"
            });
            //dodaj komentarz


            //sprawdz że komentarz się dodał
        }
        public void Dispose()
        {
           Browser.Close();
        }
    }
}
