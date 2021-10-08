using System;

namespace Coins___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een bedrag in!");
            double bedrag = Convert.ToDouble(Console.ReadLine());

            int euro2 = (int)bedrag / 2;
            if (euro2 != 0) 
                Console.WriteLine("2 euro: " + euro2);

            int euro1 = (int)Math.Floor(bedrag % 2); // Math.Floor is hier overbodig
            if (euro1 > 0) 
                Console.WriteLine("1 euro: " + euro1);

            bedrag = Math.Round(bedrag - (2 * euro2) - euro1,2);
           

            int cent50 = (int)(bedrag / 0.50);
            if (cent50 > 0) 
                Console.WriteLine("50 eurocent: " + cent50);

            bedrag -= cent50*0.5; //bedrag = bedrag - (cent50*0.50)
            bedrag = Math.Round(bedrag, 2);

            int cent20 = (int)(bedrag / 0.20);
            if (cent20 > 0) 
                Console.WriteLine("20 eurocent: " + cent20);
        }
    }
}
