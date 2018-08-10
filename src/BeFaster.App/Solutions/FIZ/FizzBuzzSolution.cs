using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string fizz_buzz(int number)
        {
            var result = "";
            if (((number % 3) == 0) || number.ToString().Contains("3")) result = "fizz";
            if (((number % 5) == 0) || number.ToString().Contains("5")) result += "buzz";
            if (result == "") result = number.ToString();
            if (result == "fizzbuzz") result = "fizz buzz";
            return result;
        }
    }
}
