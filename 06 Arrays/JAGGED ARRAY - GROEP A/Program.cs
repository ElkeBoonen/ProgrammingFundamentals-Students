using System;

namespace JAGGED_ARRAY___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] klassen = new string[5][];
            klassen[0] = new string[]{ "jan", "piet", "joris", "korneel"};
            klassen[1] = new string[] { "karen", "kristel", "kathleen" };
            klassen[2] = new string[] { "tom", "jerry" };
            klassen[3] = new string[] { "ed", "edd", "eddy" };
            klassen[4] = new string[] { "mik", "mak", "mon" };


            for (int i = 0; i < klassen.GetLength(0); i++)
            {
                for (int j = 0; j < klassen[i].Length; j++)
                {
                    Console.Write(klassen[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            foreach (var item in klassen[2])
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nGeef een aantal klassen in: ");
            int aantal = Convert.ToInt32(Console.ReadLine());

            klassen = new string[aantal][];

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine($"Geef namen in voor klas {i} gescheiden door spatie");
                klassen[i] = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < klassen.GetLength(0); i++)
            {
                for (int j = 0; j < klassen[i].Length; j++)
                {
                    Console.Write(klassen[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
