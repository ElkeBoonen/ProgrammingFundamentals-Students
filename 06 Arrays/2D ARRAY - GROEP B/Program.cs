using System;

namespace _2D_ARRAY___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabel1 = new int[4, 2]; //4 rijen & 2 kolommen

            int[,] tabel2 = { { 1, 2, 3},
                              { 4, 5, 6},
                              { 7, 8, 9} };

            tabel1[0, 0] = 6;
            tabel1[3, 1] = 68;
            tabel1[2, 0] = 46;

            Console.WriteLine(tabel1); //System.Int32[,]

            for (int i = 0; i < tabel1.GetLength(0); i++)
            {
                for (int j = 0; j < tabel1.GetLength(1); j++)
                {
                    Console.Write(tabel1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //foreach negeert de kolommen
            foreach (var item in tabel2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //afdwingen van de kolommen in foreach! Hou een var col bij zodat je weet op
            //welke kolom je zit én neem een nieuwe lijn als je aantal kolommen per rij bereikt
            int col = 0;
            foreach (var item in tabel2)
            {
                if (col == tabel2.GetLength(1))
                {
                    Console.WriteLine();
                    col = 0;
                }
                Console.Write(item + " ");
                col++;
            }
            Console.WriteLine();

            //som berekenen!
            int som = 0;
            foreach (var item in tabel2)
            {
                som += item;
            }
            Console.WriteLine($"Som is {som}");
            Console.WriteLine($"Gemiddelde is {som/tabel2.Length}");
            //length = totaal aantal elementen in tabel 2

        }
    }
}
