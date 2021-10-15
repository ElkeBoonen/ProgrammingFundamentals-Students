using System;
using System.Linq;

namespace _04_TEST_CODEGRADE___GROEP_A
{
    class Program
    {
        /*
         Convert an inputted binary number to a decimal number.
            input
            10000000
            output
            128
         */
        static void Main(string[] args)
        {
            string binair = Console.ReadLine();
            //hele makkelijke oplossing, maar niet de bedoeling!!
            //Console.WriteLine(Convert.ToInt32(binair, 2));

            int decimaalgetal = 0;

            for (int i = 0; i < binair.Length; i++)
            {
                int macht = binair.Length - i - 1;
                if (binair.ElementAt(i) != '0')
                {
                    decimaalgetal += (int)Math.Pow(2, macht);
                }
            }

            Console.WriteLine($"{binair} --> {decimaalgetal}");
           
        }
    }
}
