using System;

namespace FIZZBUZZ___GROEP_A
{
    class Program
    {
        /* Go through all the numbers up until 99 (or a given number) 
         * Print ‘fizz’ for every number that’s divisible by 3, 
         * print ‘buzz’ for every number divisible by 5, and 
         * print ‘fizzbuzz’ for every number divisible by 3 and by 5! 
         * If the number is not divisible either by 3 or 5, print a dash (‘-‘)!
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in");
            int getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= getal; i++)
            {
                Console.Write(i + " ");
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }

        }
    }
}
