using System;

namespace Verkeersboetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef zone in: ");
            int zone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef snelheid in: ");
            int snelheid = Convert.ToInt32(Console.ReadLine());

            /*if (((zone == 30) && (snelheid > 57)) || ((zone == 50) && (snelheid > 77))...)
            { 
                Console.WriteLine("Rechtbank")
            }*/

            /*if (zone == 30)
            {
                if (snelheid > 57) Console.WriteLine("Rechtbank");
                else if (snelheid > 47) Console.WriteLine("Boete 160");
                else if (snelheid > 37) Console.WriteLine("Boete 53");

            }
            else if (zone == 50)
            { }*/

            int aantal = snelheid - zone;

            if (aantal > 27)
            {
                Console.WriteLine("Rechtbank");
            }
            else if (aantal > 17)
            {
                Console.WriteLine("Boete 160 euro");
            }
            else if (aantal > 7)
            {
                Console.WriteLine("Boete 53 euro");
            }
            else
            {
                Console.WriteLine("Geen boete!");
            }


        }
    }
}
