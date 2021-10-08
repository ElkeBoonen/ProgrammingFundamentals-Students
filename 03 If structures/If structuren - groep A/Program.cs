using System;

namespace If_structuren___groep_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een x in: ");
            string input = Console.ReadLine();
            int x;
            bool gelukt = Int32.TryParse(input, out x);
            if (!gelukt)
            {
                Console.WriteLine("Verkeerd getal in gegeven!");
                return;
            }

            Console.Write("Geef een y in: ");
            input = Console.ReadLine();
            int y;
            gelukt = Int32.TryParse(input, out y);
            if (!gelukt)
            {
                Console.WriteLine("Verkeerd getal in gegeven! y krijgt nu de standaard waarde van 10!");
                y = 10;
            }


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

            if (x < y || x > y) //is sowieso niet gelijk!!!
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

            if (!(x == y))
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

            bool voorwaarde = x < y;
            if (voorwaarde) // zelfde als voorwaarde == true
            {
                Console.WriteLine("x is kleiner dan y");
            }
            else 
            {
                Console.WriteLine("x is groter dan of gelijk aan y");
            }

            if (!voorwaarde) 
            {
                Console.WriteLine("x is groter dan of gelijk aan y");
            }
            else
            {
                Console.WriteLine("x is kleiner dan y");
            }

        }
    }
}
