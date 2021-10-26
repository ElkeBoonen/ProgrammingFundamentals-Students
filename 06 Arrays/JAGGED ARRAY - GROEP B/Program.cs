using System;

namespace JAGGED_ARRAY___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] punten = new int[3][];
            //punten per klas! 
            punten[0] = new int[] { 2, 1, 0, 5, 4, 3 };
            punten[1] = new int[] { 5, 5, 4 };
            punten[2] = new int[] { 1, 1, 5, 2 };

            Console.WriteLine("Alle punten:");
            for (int i = 0; i < punten.GetLength(0); i++)
            {
                foreach (var item in punten[i])
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            //namen per klas
            string[][] namen = new string[3][];
            for (int i = 0; i < namen.GetLength(0); i++)
            {
                Console.Write($"Namen voor klas {i} gescheiden door spatie: ");
                namen[i] = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"Naam eerste kind 3e klas: {namen[2][0]}");
            Console.WriteLine("Alle namen: ");
            for (int i = 0; i < namen.GetLength(0); i++)
            {
                for (int j = 0; j < namen[i].Length; j++)
                {
                    Console.Write(namen[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
