using System;

namespace If_structures___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal in: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //IF ELSE IF ELSE --> versie 1
            if (number < 100)
            {
                Console.WriteLine("Getal is kleiner dan 100!");
            }
            else if (number == 100)
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is groter dan 100!");
            }

            //IF en in ELSE structuur terug een IF --> versie 2
            if (number < 100)
            {
                Console.WriteLine("Getal is kleiner dan 100!");
            }
            else
            {
                if (number == 100)
                {
                    Console.WriteLine("Getal is gelijk aan 100!");
                }
                else 
                {
                    Console.WriteLine("Getal is groter dan 100!");
                }
            }

            //IF-structuur in IF-structuur en dan een ELSE --> versie 3
            if (number <= 100)
            {
                if (number == 100)
                {
                    Console.WriteLine("Getal is gelijk aan 100!");
                }
                else
                {
                    Console.WriteLine("Getal is kleiner dan 100!");
                }
            }
            else
            {
                Console.WriteLine("Getal is groter dan 100!");
            }

            //DIT IS NIET CORRECT!! --> foute versie ;))
            //starten met if => sowieso nieuwe if-structuur die niets meer
            //met voorgaande te maken heeft!!
            if (number < 100) {
                Console.WriteLine("Getal is kleiner dan 100! (foute versie!)");
            }
            if (number > 100) { //deze if heeft NIETS meer te maken met de voorgaande if 
                Console.WriteLine("Getal is groter dan 100! (foute versie!)");
            }
            else {
                Console.WriteLine("Getal is gelijk aan 100! (foute versie!)");
            }

            //versie 4
            if (number != 100)
            {
                if (number < 100)
                {
                    Console.WriteLine("Getal is kleiner dan 100!");
                }
                else
                {
                    Console.WriteLine("Getal is is groter dan 100!");
                }
            }
            else {
                Console.WriteLine("Getal is gelijk aan 100!");
            }

            //versie 5
            if (number == 100)
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }
            else
            {
                if (number < 100)
                {
                    Console.WriteLine("Getal is kleiner dan 100!");
                }
                else
                {
                    Console.WriteLine("Getal is is groter dan 100!");
                }
            }

            //versie 6 --> controleren of getal gewoon gelijk is aan 100
            if (number == 100)
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is niet gelijk aan 100!");
            }

            //versie 7 --> controleren of getal gewoon gelijk is aan 100
            if (number > 100 || number < 100)
            {
                Console.WriteLine("Getal is niet gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }

            //versie 8 --> controleren of getal gewoon gelijk is aan 100
            if (number != 100)
            {
                Console.WriteLine("Getal is niet gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }

            //versie 9 --> controleren of getal gewoon gelijk is aan 100
            if (! (number == 100)) //omgekeerde van 'getal is gelijk aan 100'
            {
                Console.WriteLine("Getal is niet gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }

            //versie 10 --> werken met een boolean
            bool voorwaarde = number != 100;
            if (voorwaarde) //(voorwaarde == true)
            {
                Console.WriteLine("Getal is niet gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }

            //versie 11 --> werken met een boolean
            if (!voorwaarde) //(omgekeerde voorwaarde)
            {
                Console.WriteLine("Getal is gelijk aan 100!");
            }
            else
            {
                Console.WriteLine("Getal is niet gelijk aan 100!");
            }

        }
    }
}
