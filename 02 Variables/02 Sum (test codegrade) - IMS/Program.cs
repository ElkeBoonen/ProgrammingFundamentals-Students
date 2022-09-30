using System;

namespace _02_Sum__test_codegrade____IMS
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
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            //string antwoord = Console.ReadLine();
            //double getalA = Convert.ToDouble(antwoord);
            
            double getalA = Convert.ToDouble(Console.ReadLine()); //verkorte versie
            double getalB = Convert.ToDouble(Console.ReadLine()); //verkorte versie
            double getalC = Convert.ToDouble(Console.ReadLine()); //verkorte versie

            double som = getalA + getalB + getalC;

            Console.WriteLine((int)som); //Geen math.round gebruiken want dat rondt af!
        }
    }
}
