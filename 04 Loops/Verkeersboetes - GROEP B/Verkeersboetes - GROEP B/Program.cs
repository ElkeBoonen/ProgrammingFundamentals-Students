using System;

namespace Verkeersboetes___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gelukt_zone, gelukt_snelheid;

            Console.Write("Geef zone in: ");
            string input_zone = Console.ReadLine();
            Console.Write("Geef snelheid in: ");
            string input_snelheid = Console.ReadLine();
            int zone, snelheid;

            gelukt_zone = Int32.TryParse(input_zone, out zone);
            gelukt_snelheid = Int32.TryParse(input_snelheid, out snelheid);

            while (gelukt_snelheid && gelukt_zone)
            {
               
                /* regel 1: start altijd met meest exclusieve grens, 
                 * dus eerst > 57, dan > 47, dan pas > 37 
                 * want 60 is groter dan 37,47 en 57 maar we moeten > 57 hebben! 
                 * 
                 * regel 2: zoek naar een structuur!!!!*/

                int verschil = snelheid - zone;

                if (verschil > 27)
                {
                    Console.WriteLine("rechtbank!");
                }
                else if (verschil > 17)
                {
                    Console.WriteLine("160 euro boete!");
                }
                else if (verschil > 7)
                {
                    Console.WriteLine("53 euro boete!");
                }
                else
                {
                    Console.WriteLine("geen boete!");
                }

                Console.Write("Geef zone in: ");
                input_zone = Console.ReadLine();
                Console.Write("Geef snelheid in: ");
                input_snelheid = Console.ReadLine();

                gelukt_zone = Int32.TryParse(input_zone, out zone);
                gelukt_snelheid = Int32.TryParse(input_snelheid, out snelheid);

            } 
           

            /*
            if (zone==30)
            {
                if (snelheid > 57) //
                else if (snelheid > 47) //
                else if //...
            }
            else if (zone==50)*/






        }
    }
}
