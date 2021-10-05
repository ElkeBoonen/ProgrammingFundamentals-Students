using System;

namespace _03_If_structuren___IMS_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een x in: ");
            string invoerX = Console.ReadLine();
            Console.Write("Geef een y in: ");
            string invoerY = Console.ReadLine();

            int x; //als invoer geen getal is, wordt x sowieso 0 door TryParse
            bool gelukt = Int32.TryParse(invoerX, out x);
            if (!gelukt) Console.WriteLine("Geen goede x ingegeven! x is nu standaard 0!");

            //ook een optie om uitvoering gewoon te stoppen!
            /*if (!gelukt)
            {
                Console.WriteLine("Geen goede x ingegeven, we stoppen ermee!!!");
                return;
            }*/

            int y;
            gelukt = Int32.TryParse(invoerY, out y);
            if (!gelukt) Console.WriteLine("Geen goede y ingegeven! y is nu standaard 0!");


            if (x < y)
            {
                Console.WriteLine("x is kleiner dan y!");
            }
            else if (x == y)
            {
                Console.WriteLine("x is gelijk aan y!");
            }
            else
            {
                Console.WriteLine("x is groter dan y!");
            }

            //nieuwe manier om hetzelfde te doen!
            if (x < y)
            {
                Console.WriteLine("x is kleiner dan y!");
            }
            if (x == y)
            {
                Console.WriteLine("x is gelijk aan y!");
            }
            if (x > y)
            {
                Console.WriteLine("x is groter dan y!");
            }

            //if structure nesten

            if (x < y)
            {
                Console.WriteLine("x is kleiner dan y!");
            }
            else
            {
                if (x == y)
                {
                    Console.WriteLine("x is gelijk aan y!");
                }
                else
                {
                    Console.WriteLine("x is groter dan y!");
                }

            }

            if (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("x is groter dan y!");
                }
                else
                {
                    Console.WriteLine("x is kleiner dan y!");
                }
            }
            else 
            {
                Console.WriteLine("x is gelijk aan y!");
            }

            //voorwaarden combineren
            if (x < y || x > y) // || = OR
            {
                Console.WriteLine("x is niet gelijk aan y!");
            }
            else
            {
                Console.WriteLine("x is gelijk aan y!");
            }

            if (!(x < y || x > y)) //! not 
            {
                Console.WriteLine("x is gelijk aan y!");
            }
            else
            {
                Console.WriteLine("x is niet gelijk aan y!");
            }

            if (x < y && x > 0)
            {
                Console.WriteLine("x is kleiner dan y en positief!");
            }
            else
            {
                Console.WriteLine("x is niet kleiner dan y of negatief!");
            }

            bool resultaat = x < y;
            if (resultaat == true) Console.WriteLine("x is kleiner dan y");
            else Console.WriteLine("x is niet kleiner dan y");
            //zelfde als hierboven
            if (resultaat) Console.WriteLine("x is kleiner dan y");
            else Console.WriteLine("x is niet kleiner dan y");

            if (resultaat == false) Console.WriteLine("x is niet kleiner dan y");
            else Console.WriteLine("x is kleiner dan y");
            //zelfde als hierboven
            if (!resultaat) Console.WriteLine("x is niet kleiner dan y");
            else Console.WriteLine("x is kleiner dan y");

            /////////////////////////////////////////////////
            ////////////////SWITCH STRUCTUUR/////////////////
            /////////////////////////////////////////////////

            DateTime today = DateTime.Now;
            int weekdag = (int)today.DayOfWeek;

            Console.WriteLine(weekdag);
            if (weekdag == 1) Console.WriteLine("Het is maandag!");
            else if (weekdag == 2) Console.WriteLine("Het is dinsdag!");
            else if (weekdag == 3) Console.WriteLine("Het is woensdag!");
            else if (weekdag == 4) Console.WriteLine("Het is donderdag!");
            else if (weekdag == 5) Console.WriteLine("Het is vrijdag!");
            else if (weekdag == 6) Console.WriteLine("Het is zaterdag!");
            else if (weekdag == 7) Console.WriteLine("Het is zondag!");
            else Console.WriteLine("Euh... dit kan niet, de VS is stuk ;)");

            switch (weekdag)
            {
                case 1: Console.WriteLine("Het is maandag!"); break;
                case 2: Console.WriteLine("Het is dinsdag!"); break;
                case 3: Console.WriteLine("Het is woensdag!"); break;
                case 4: Console.WriteLine("Het is donderdag!");break;
                case 5: Console.WriteLine("Het is vrijdag!"); break;
                case 6: Console.WriteLine("Het is zaterdag!"); break;
                case 7: Console.WriteLine("Het is zondag!"); break;
                default: Console.WriteLine("Euh... dit kan niet, de VS is stuk ;)"); break;
            }


        }
    }
}
