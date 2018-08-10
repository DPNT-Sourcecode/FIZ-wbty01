using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizBuzSolutionTest
    {
        [TestCase(1, ExpectedResult = "1")]
        public string fizz_buzz_test1(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }
        [TestCase(3, ExpectedResult = "fizz")]
        public string fizz_buzz_test2(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }
        [TestCase(5, ExpectedResult = "buzz")]
        public string fizz_buzz_test3(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }
        [TestCase(15, ExpectedResult = "fizz buzz")]
        public string fizz_buzz_test4(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }
        [TestCase(9999, ExpectedResult = "fizz")]
        public string fizz_buzz_test5(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }

        [TestCase(5999, ExpectedResult = "buzz")]
        public string fizz_buzz_test6(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }

        [TestCase(1111, ExpectedResult = "1111")]
        public string fizz_buzz_test7(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }

        [TestCase(7231, ExpectedResult = "fizz")]
        public string fizz_buzz_test8(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }

        [TestCase(7531, ExpectedResult = "fizz buzz")]
        public string fizz_buzz_test9(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }

    }
}
