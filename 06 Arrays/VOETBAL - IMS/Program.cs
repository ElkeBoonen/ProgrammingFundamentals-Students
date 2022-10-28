using System;

namespace VOETBAL___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] voetbal = new string[3][];
            for (int i = 0; i < voetbal.GetLength(0); i++)
            {
                Console.Write("Geef spelers gescheiden door een spatie: ");
                voetbal[i] = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"Formatie: {voetbal[0].Length} - {voetbal[1].Length} - {voetbal[2].Length}");

            foreach (var item in voetbal)
            {
                foreach (var speler in item)
                {
                    Console.Write(speler + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
