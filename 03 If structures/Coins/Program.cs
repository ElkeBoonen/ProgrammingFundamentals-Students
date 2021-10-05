using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een bedrag in: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            int euro2 = (int)amount / 2;
            if (euro2 > 0) Console.WriteLine("2 euro: " + euro2);

            int euro1 = (int)amount % 2;
            if (euro1 > 0) Console.WriteLine("1 euro: " + euro1);

            double nadekomma = amount - (2 * euro2) - euro1;

            if (nadekomma > 0.50)
            {
                Console.WriteLine("50 eurocent: 1");
                nadekomma -= 0.50;
            }

            int eurocent20 = (int)(nadekomma / 0.2);
            if (eurocent20 > 0) Console.WriteLine("20 eurocent: " + eurocent20);



        }
    }
}
