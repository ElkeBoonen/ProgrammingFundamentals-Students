using System;
using System.Linq;

namespace Binary_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Convert an inputted binary number to a decimal number.
            input: 10000000
            output: 128.
             */

            Console.WriteLine("Enter binary number: ");
            string binary = Console.ReadLine();

            int number = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '1')
                {
                    number += (int)Math.Pow(2, i);
                }
                //Console.WriteLine(binary.ElementAt(i));
            }
            Console.WriteLine(number);

        }
    }
}
