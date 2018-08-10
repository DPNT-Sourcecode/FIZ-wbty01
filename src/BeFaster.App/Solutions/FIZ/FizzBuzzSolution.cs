using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string fizz_buzz(int number)
        {
            var result = "";
            var deluxe = false;
            if (((number % 3) == 0) || number.ToString().Contains("3")) result = "fizz "; 
            if (((number % 5) == 0) || number.ToString().Contains("5")) result += "buzz ";
            if ((number % 3) == 0 && number.ToString().Contains("3")) deluxe = true;
            if ((number % 5) == 0 && number.ToString().Contains("5")) deluxe = true;
            if (deluxe) result += (number % 2 == 0) ? "deluxe" : "fake deluxe";
            if (result == "") result = number.ToString();
            return result.TrimEnd();
        }

    }
}
