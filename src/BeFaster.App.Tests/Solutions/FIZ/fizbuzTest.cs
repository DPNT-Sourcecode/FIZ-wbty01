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
    }
}
