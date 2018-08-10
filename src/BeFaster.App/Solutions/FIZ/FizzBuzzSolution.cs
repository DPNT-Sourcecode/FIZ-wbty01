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
            if (deluxe) result += "deluxe";
            if ((number > 10 && number.ToString().Replace(number.ToString()[0].ToString(), "") == "")) result += "deluxe";
            if (result.Contains("deluxe") && (number % 2) != 0) result=result.Replace("deluxe", "fake deluxe");
            if (result == "") result = number.ToString();
            return result.TrimEnd();
        }

    }
}
