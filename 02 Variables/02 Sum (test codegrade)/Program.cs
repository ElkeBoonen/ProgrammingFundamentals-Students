using System;

namespace _02_Sum__test_codegrade_
{
    internal class Program
    {
        /*
            Read in three decimal numbers, and calculate the sum. Output the sum as an integer.

            Problems with . as the decimal separator? Add this line of code in your Main-method before you start reading input from the console:
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Input/Output
            input:
            23
            78
            10.6
            output:
            111
         
         */


        static void Main(string[] args)
        {
            //to read in decimals with . as decimal separator
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //string answer = Console.ReadLine();
            //double number1 = Convert.ToDouble(answer)

            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2 + number3;

            //int sumInt = (int)sum;
            //int sum = (int)(number1 + number2 + number3);

            Console.WriteLine((int)sum); //output as an integer

            //if you are using (int) --> cut off decimal part
            //if you are converting --> it will round!
            //5.4 --> 5 (when converting)
            //5.7 --> 6 (when converting)

            Console.WriteLine(sum.ToString("0.00")); //output as a decimal with two decimal digits 0.00

        }
    }
}
