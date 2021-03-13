using System;

namespace Whileloops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter y to continue: ");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.WriteLine("yes");
                Console.WriteLine("Enter y to continue: ");
                answer = Console.ReadLine();
            }

            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            //x = 2
            //2 4 8 16 32 64 128 ...

            Console.WriteLine("MAX VALUE = " + Int16.MaxValue);
            Console.WriteLine("\nRESULT = 1 - print at the end");
            int result = 1;
            while (result < Int16.MaxValue)
            {
                result *= x; //result = result * x
                Console.Write(result + " ");
            }

            Console.WriteLine("\nRESULT = x - print at the end");
            result = x;
            while (result < Int16.MaxValue)
            {
                result *= x; //result = result * x
                Console.Write(result + " ");
            }

            Console.WriteLine("\nRESULT = 1 - print at the beginning");
            result = 1;
            while (result < Int16.MaxValue)
            {
                Console.Write(result + " ");
                result *= x; //result = result * x
            }

            Console.WriteLine("\nRESULT = x - print at the beginning");
            result = x;
            while (result < Int16.MaxValue)
            {
                Console.Write(result + " ");
                result *= x; //result = result * x
            }

            Console.WriteLine("\nDO WHILE - RESULT = 1 - print at the beginning");
            result = 1;
            do
            {
                Console.Write(result + " ");
                result *= x; //result = result * x 
            } while (result < Int16.MaxValue);

            Console.WriteLine("\nDO WHILE - RESULT = 1 - print at the end");
            result = 1;
            do
            {
                result *= x; //result = result * x 
                Console.Write(result + " ");
            } while (result < Int16.MaxValue);

            Console.WriteLine("\nDO WHILE - RESULT = x - print at the beginning");
            result = x;
            do
            {
                Console.Write(result + " ");
                result *= x; //result = result * x 
            } while (result < Int16.MaxValue);

            Console.WriteLine("\nDO WHILE - RESULT = x - print at the end");
            result = x;
            do
            {
                result *= x; //result = result * x 
                Console.Write(result + " ");
            } while (result < Int16.MaxValue);

            Console.WriteLine("\n converting for to while");

            //convert for to while
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int count = 0;
            while (count < 10)
            {
                Console.WriteLine(count++);
                //count++;
            }

            /*
             
             Convert an inputted binary number to a decimal number.
                input 10000000
                output 128

                input 11
                output 3
             */

            /*string input = "10000000";

            for (int i = 0; i < input.Length; i++)
            {
                input.ElementAt()
            }*/



        }
    }
}
