using System;

namespace GAME___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int getal = random.Next(0, 100);

            Console.Write("Doe eens een gok: ");
            int gok = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            while (gok != getal && count < 10)
            {
                if (gok < getal)
                {
                    Console.WriteLine("HOGER");
                }
                else
                {
                    Console.WriteLine("LAGER");
                }
                Console.Write("Doe eens een gok: ");
                gok = Convert.ToInt32(Console.ReadLine());
                count++;
                Console.Beep();
            }



        }
    }
}
