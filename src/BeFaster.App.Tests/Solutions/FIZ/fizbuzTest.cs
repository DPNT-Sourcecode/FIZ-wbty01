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
        [TestCase(9999, ExpectedResult = "9999")]
        public string fizz_buzz_test5(int x)
        {
            return FizzBuzzSolution.fizz_buzz(x);
        }

    }
}
