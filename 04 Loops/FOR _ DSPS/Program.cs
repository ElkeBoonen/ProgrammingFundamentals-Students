using System;

namespace FOR___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //idiot version
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");

            //better version
            Console.WriteLine("\nFOR LOOP i=0 i <= 10");
            for (int i = 0; i <= 10; i++) //same condition -> i < 11
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
                //Console.WriteLine(number + " * " + i + " = " + result);
            }

            Console.WriteLine("\nFOR LOOP i=1 i <= 10");
            for (int i = 1; i <= 10; i++) //same condition -> i < 11
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
                //Console.WriteLine(number + " * " + i + " = " + result);
            }

            Console.WriteLine("\nFOR LOOP i=0 i <= 10 stepsize 2");
            for (int i = 0; i <= 10; i+=2) 
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            Console.WriteLine("\nFOR LOOP i=0 i <= 10 stepsize power of 2");
            //BE CAREFUL --> INFINITE LOOP, START FROM 1
            for (int i = 1; i <= 20; i *= 2)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            Console.WriteLine("\nFOR LOOP i=10 i >= 0 i--");
            //NO OUTPUT  --> for (int i = 10; i <= 0; i--)
            //for (int i = 10; i >= 0; i++) 'inifite loop', but it will stop when result is too big for an integer --> overflow exception
            for (int i = 10; i >= 0; i--)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            //PRINT 3 6 9 12 15 18 21 14 etc...
            Console.WriteLine("\nVERSION 1: sequence 3 6 9 12 15 18 ...");
            for (int i = 1; i <= 33; i++)
            {
                int result = i * 3;
                Console.Write(result + " ");
            }

            Console.WriteLine("\nVERSION 2: sequence 3 6 9 12 15 18 ...");
            for (int i = 3; i <= 100; i+=3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nVERSION 3: sequence 3 6 9 12 15 18 ...");
            for (int i = 3; i <= 100; i++)
            {
                if (i%3==0) Console.Write(i + " ");
            }

            Console.Write("\n\nEnter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTABLE OF j's");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nTABLE OF stars");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nTABLE OF i's");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            /* x = 5
             1
             2 2
             3 3 3
             4 4 4 4
             5 5 5 5 5

             x = 3
             1
             2 2 
             3 3 3
             */

            Console.WriteLine("\nPYRAMID");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
