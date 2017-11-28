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
            double result = math.Multiply(101, 4.5);

            // assert - sprawdzenie wyników
            Assert.Equal(454.5, result);
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

        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(1, 2, 3)]
        [InlineData(22, 11, 33)]
        [InlineData(0, 0, 0)]

        public void TheoryExample(double x, double y, double expected)
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Add(x, y);

            // assert - sprawdzenie wyników
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(1, 2, 2)]
        [InlineData(22, 11, 242)]
        [InlineData(0, 0, 0)]

        public void TheoryExamplemultipli(double x, double y, double expected)
        {
            // arrange - przygotowanie
            //TestMathemacs math = new TestMathemacs();
            var math = new Matematyka();

            // act - wwykonanie testu
            double result = math.Multiply(x, y);

            // assert - sprawdzenie wyników
            Assert.Equal(expected, result);
        }
    }
}
