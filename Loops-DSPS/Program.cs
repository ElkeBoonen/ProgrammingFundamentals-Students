using System;

namespace Loops_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x? ");
            int x = Convert.ToInt32(Console.ReadLine());

            //0 --> 10
            Console.WriteLine("Table of multiplication: 0 <= 10");
            for (int i = 0; i <= 10; i++) // < 11
            {
                int result = i * x;
                Console.WriteLine(i +  " * " + x + " = " + result);
            }

            //10 --> 0
            Console.WriteLine("Table of multiplication: 10 >= 0");
            for (int i = 10; i >= 0; i--) // < 11
            {
                int result = i * x;
                Console.WriteLine(i + " * " + x + " = " + result);
            }

            //0 --> 10 by 2
            Console.WriteLine("Table of multiplication: 0 <= 10 (stepsize 2)");
            for (int i = 0; i <= 10; i = i + 2)  // i+=2
            {
                int result = i * x;
                Console.WriteLine(i + " * " + x + " = " + result);
            }

            //0 --> 100 
            Console.WriteLine("\n\n0 --> 100, % 3");
            for (int i = 0; i <= 100; i++)  
            {
                if (i % 3 == 0) Console.Write(i + " ");
            }

            Console.WriteLine("\n\n0 --> 100, step 3");
            for (int i = 0; i <= 100; i+=3)  // i = i +3
            {
                Console.Write(i + " ");
            }
            

            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(i + "-" + j + " ");
                }
                Console.WriteLine();

            }


            //making a triangle
            //*
            //**
            //***
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //making a triangle
            //***
            //**
            //*
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //making a triangle
            //***
            // **
            //  *
            for (int i = 5; i > 0; i--)
            {
                int spaces = 5 - i;
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //making a triangle
            //***
            // **
            //  *
            int spaces1 = 0;
            for (int i = 5; i > 0; i--)
            {
                
                for (int j = 0; j < spaces1; j++)
                {
                    Console.Write("  ");
                }
                spaces1++;
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            

            Console.Write("yes to continue: ");
            string answer = Console.ReadLine();

            while (answer =="yes")
            {
                Console.Write("yes to continue: ");
                answer = Console.ReadLine();
            }*/

            Console.Write("x? ");
            int x = Convert.ToInt32(Console.ReadLine());


            for (int i=0; i<=10; i++)
            {
                int result = (int)Math.Pow(x, i);
                Console.WriteLine(x + "^" + i + " = " + result);
            }

            Console.WriteLine("\n");

            int res_exp = 1;
            while (res_exp < 1000000)
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(res_exp + " ");
                res_exp = res_exp * x;
            }
            Console.Write(res_exp + " ");


            Console.WriteLine("\n");
            res_exp = 1;
            Console.Write(res_exp + " ");
            while (res_exp < 1000000)
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                res_exp = res_exp * x;
                Console.Write(res_exp + " ");
            }


            Console.WriteLine("\n\nWHILE start with x!!!");
            res_exp = x;
            while (res_exp < 1000000)
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(res_exp + " ");
                res_exp = res_exp * x;
            }

            Console.WriteLine("\n\nDO WHILE start with x!!!");
            res_exp = x;
            do
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(res_exp + " ");
                res_exp = res_exp * x;
            } while (res_exp < 1000000) ;
        }
    }
}
