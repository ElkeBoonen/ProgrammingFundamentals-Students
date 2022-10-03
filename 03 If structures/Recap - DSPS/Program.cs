using System;

namespace Recap___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read in two integers and perform various math operations, such as *, %, /, and +.
            //Output the results as a decimal with 2 decimal places

            Console.Write("Enter an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine($"sum = {sum.ToString("0.00")}");

            int subtraction = a - b;
            Console.WriteLine($"subtraction = {subtraction.ToString("0.00")}");

            int multiplication = a * b;
            Console.WriteLine($"multiplication = {multiplication.ToString("0.00")}");

            int integerDivision = a / b; //2 integers = integer result even if it stored in a double
            Console.WriteLine($"int division = {integerDivision.ToString("0.00")}");

            double division = (double) a / b; //to get a 'normal' division cast one of the two integers to a double
            Console.WriteLine($"'normal' division = {division.ToString("0.00")}");

            int modulo = a % b;
            Console.WriteLine($"modulo (remainder after integer division) = {modulo.ToString("0.00")}");


        }
    }
}
