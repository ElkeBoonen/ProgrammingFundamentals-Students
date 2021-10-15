using System;

namespace FOR___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //drie onderdelen samen bepalen aantal iteraties!!!!!
            for (int i = 0; i < 10; i+=3)
            {
                Console.Write("* ");
            }

            Console.WriteLine("\nDE MAALTAFELS");
            Console.Write("Geef een getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("0 <= 10 --> 11 keer!");
            for (int i = 0; i <= 10; i++) // < 11 --> even goed!
            {
                int result = i * getal;
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("1 <= 10 --> 10 keer!");
            for (int i = 1; i <= 10; i++) // < 11 --> even goed!
            {
                int result = i * getal;
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("0 < 10 --> 10 keer!");
            for (int i = 0; i < 10; i++) // < 11 --> even goed!
            {
                int result = i * getal;
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("10 > 0 --> 10 keer!");
            //let op met oneindige lussen als je voorwaarden omdraait!!!!
            for (int i = 10; i > 0; i--) 
            {
                int result = (i * getal);
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("10 > -1 --> 11 keer!");
            for (int i = 10; i > -1; i--) // >=0
            {
                int result = (i * getal);
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("0 --> 10 met +=2 --> 5 keer");
            for (int i = 0; i < 10; i+=2)  
            {
                int result = (i * getal);
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("1 --> 10 met *=2 --> ");
            //let op!!!! i mag niet 0 zijn anders oneindige lus
            for (int i = 1; i < 10; i *= 2)
            {
                int result = (i * getal);
                Console.WriteLine($"{i} * {getal} = {result}");
            }

            Console.WriteLine("\n\n2 FOR LOOPS");
            for (int i = 0; i < getal; i++)
            {
                for (int j = 0; j < getal; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /*
             * *
             * * *
             * * * *
             */
            for (int i = 0; i < getal; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /* * * * *
             * * * *
             * * *
             * *
             */

            for (int i = getal; i > 0 ; i--)
            {
                for (int j = i; j > 0 ; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < getal; i++)
            {
                for (int j = getal; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
