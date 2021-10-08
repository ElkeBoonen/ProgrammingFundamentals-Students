using System;

namespace If_structuren___groep_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een x in: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een y in: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine("x is kleiner dan y");
            }
            else if (x == y)
            {
                Console.WriteLine("x is gelijk aan y");
            }
            else
            {
                Console.WriteLine("x is groter dan y");
            }

            //kortere schrijfwijze
            if (x < y) Console.WriteLine("x is kleiner dan y");
            else if (x == y) Console.WriteLine("x is gelijk aan y");
            else Console.WriteLine("x is groter dan y");

            //Let op zelfde if-structuur!! anders rare resultaten!
            if (x < y)
            {
                Console.WriteLine("x is kleiner dan y");
            }
            if (x == y)
            {
                Console.WriteLine("x is gelijk aan y");
            }
            else
            {
                Console.WriteLine("x is groter dan y");
            }


            //ANDERE SCHRIJFWIJZEN
            if (x < y)
            {
                Console.WriteLine("x is kleiner dan y");
            }
            if (x == y)
            {
                Console.WriteLine("x is gelijk aan y");
            }
            if (x > y)
            {
                Console.WriteLine("x is groter dan y");
            }

            if (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("x is groter dan y");
                }
                else
                {
                    Console.WriteLine("x is kleiner dan y");
                }
            }
            else
            {
                Console.WriteLine("x is gelijk aan y");
            }

            if (x == y)
            {
                Console.WriteLine("x is gelijk aan y");
            }
            else
            {
                if (x > y)
                {
                    Console.WriteLine("x is groter dan y");
                }
                else
                {
                    Console.WriteLine("x is kleiner dan y");
                }
            }


        }
    }
}
