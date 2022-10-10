using System;

namespace WHILE___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("START! PRESS Y TO CONTINUE: ");
            string answer = Console.ReadLine();

            while (answer == "Y")
            {
                Console.Write("PRESS Y TO CONTINUE: ");
                answer = Console.ReadLine();
            }


            Random random = new Random();
            int number = random.Next(1,20);
            Console.Write("Guess a number: ");
            int guess = Convert.ToInt32(Console.ReadLine()) ;

            int count = 1;
            //bool flag = true;

            while (number!=guess && count < 10) //while (flag)
            {
                //if (guess == number) flag = false;
                //if (count == 10) flag = false;

                Console.Write("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            */

            //sequence 3 6 9 12 15 ....
            Console.WriteLine("SEQUENCE 3 6 9 12 15... ");
            int i = 3;
            while (i < 100) //for (int i = 3; i < 100; i+=3)
            {
                Console.Write(i + " ");
                i += 3;
            }

            //sequence 3 9 81 273 ...... --> Int16.MaxValue
            Console.WriteLine("\nSEQUENCE 3 9 81... ");
            i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= 3;
            }


            Console.Write("\nEnter a number x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //order of statements is always important!!
            Console.WriteLine("\nSEQUENCE 1");
            i = x;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }

            //order of statements is always important!!
            Console.WriteLine("\nSEQUENCE 2");
            i = x;
            while (i < Int16.MaxValue)
            {
                i *= x;
                Console.Write(i + " ");
            }

            //do while will always loop at least 1 time!!!
            //order of statements is always important!!
            Console.WriteLine("\nSEQUENCE 3");
            i = x;
            do
            {
                Console.Write(i + " ");
                i *= x;
            } while (i < Int16.MaxValue);

            //do while will always loop at least 1 time!!!
            //order of statements is always important!!
            Console.WriteLine("\nSEQUENCE 4");
            i = x;
            do
            {
                i *= x;
                Console.Write(i + " ");
            } while (i < Int16.MaxValue);

        }
    }
}
