using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace automatyzacja_day1
{
    public class TestMathemacs
    {
        [Fact]
        public void Method_add_returns_sum_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Add(10, 20);

            // assert - sprawdzenie wyników
            Assert.Equal(30, result);
        }

        [Fact]
        public void Method_add_returns_fraction_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Add(33.33, 20);

            // assert - sprawdzenie wyników
            Assert.Equal(53.33, result);
        }
        [Fact]
        public void Method_substract_returns_difference_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Substract(50, 20);

            // assert - sprawdzenie wyników
            Assert.Equal(30, result);
        }
        [Fact]
        public void Method_substract_returns_fraction_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Substract(50, 20.33);

            // assert - sprawdzenie wyników
            Assert.Equal(29.67, result);
        }
        [Fact]
        public void Method_multiply_returns_product_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Multiply(33, 8);

            // assert - sprawdzenie wyników
            Assert.Equal(264, result);
        }
        [Fact]
        public void Method_multiply_returns_fraction_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Multiply(33, 8.22);

            // assert - sprawdzenie wyników
            Assert.Equal(271.26, result);
        }
        [Fact]
        public void Method_divide_returns_quotient_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Divide(100, 2);

            // assert - sprawdzenie wyników
            Assert.Equal(50, result);
        }
        [Fact]
        public void Method_divide_returns_fraction_of_given_values()
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Divide(100, 11);

            // assert - sprawdzenie wyników
            Assert.Equal(9.090909090909091, result);
        }
    }
}
