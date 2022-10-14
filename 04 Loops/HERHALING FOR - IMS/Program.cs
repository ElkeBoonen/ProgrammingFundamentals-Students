using System;

namespace HERHALING_FOR___IMS
{
    internal class Program
    {
        //Write a program to print all even numbers between two given numbers.
        static void Main(string[] args)
        {
            Console.Write("Geef een eerste getal in: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een tweede getal in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            for (int i = getal1; i <= getal2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                //Console.Write($"{i} ");
            }
            Console.WriteLine();

            int count = getal1;
            while (count <= getal2)
            {
                if (count % 2 == 0)
                {
                    Console.Write(count + " ");
                }
                count++;
            }

            Console.WriteLine();
            while (getal1 <= getal2)
            {
                if (getal1 % 2 == 0)
                {
                    Console.Write(getal1 + " ");
                }
                getal1++;
            }

        }
    }
}
