using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string fizz_buzz(int number)
        {
            var result = "";
            if ((number % 3) == 0) result = "fizz ";
            if ((number % 5) == 0) result += "buzz";
            if (result == "") result = number.ToString();
            return result.TrimEnd();
        }
    }
}
