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
            //dodaj komentarz
            //sprawdz że komentarz się dodał
        }
        public void Dispose()
        {
            Browser.Close();
        }
    }
}
