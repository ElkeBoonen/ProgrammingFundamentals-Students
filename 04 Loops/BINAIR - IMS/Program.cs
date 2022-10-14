using System;
using System.Linq;

namespace BINAIR___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef binair getal in: ");
            string binair = Console.ReadLine();

            int getal = 0;
            for (int i = 0; i < binair.Length; i++)
            {
                Console.Write(binair[binair.Length - i - 1] + " "); //of binair.ElementAt(i)
                //omgekeerde indexen --> heel vaak lengte van woord - 1 - i

                if (binair.ElementAt(binair.Length - i - 1) == '1')
                {
                    getal = (int)(getal + Math.Pow(2, i));
                }
            }
            Console.WriteLine("\nDecimaal getal = " + getal);
        }
    }
}
