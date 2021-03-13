using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;

            Console.WriteLine("0 <= 10");
            for (int i = 0; i <= 10; i++)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }
            Console.WriteLine("1 <= 10");
            for (int i = 1; i <= 10; i++)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }
            Console.WriteLine("1 < 10");
            for (int i = 1; i < 10; i++)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }
            Console.WriteLine("10 <= 10");
            for (int i = 10; i <= 10; i++)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("10 < 10");
            for (int i = 10; i < 10; i++)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("10 > 0 ");
            for (int i = 10; i > 0; i--) //i++ gives infinite loop!!!
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("10 => 0 ");
            for (int i = 10; i >= 0; i--) //i++ gives infinite loop!!!
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("0 <= 10 step by +2");
            for (int i = 0; i <= 10; i+=2)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("1 <= 10 step by *2"); //START AT 1 OTHERWISE INFINITE LOOP
            for (int i = 1; i <= 10; i *= 2)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("10 > 0 step by -3"); 
            for (int i = 10; i > 0; i -= 3)
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }


            Console.WriteLine("matrix of stars 3 rows - 4 columns");
            for (int i = 0; i < 3; i++) // starting with rows!!!
            {
                
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /*
             Create this triangle

                *

                * *

                * * *

                * * * *
             */
            Console.WriteLine("TRIANGLE");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
