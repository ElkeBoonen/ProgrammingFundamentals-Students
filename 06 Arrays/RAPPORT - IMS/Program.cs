using System;

namespace RAPPORT___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef aantal leerlingen in: ");
            int lln = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef aantal toetsen in: ");
            int toetsen = Convert.ToInt32(Console.ReadLine());

            int[,] rapport = new int[lln, toetsen];

            for (int i = 0; i < lln; i++)
            {
                for (int j = 0; j < toetsen; j++)
                {
                    Console.Write($"Cijfer toets {j+1} van leerling {i+1}: ");
                    rapport[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //gemiddelde per leerling
            for (int i = 0; i < lln; i++) //rapport.GetLength(0)
            {
                int sum = 0;
                for (int j = 0; j < toetsen; j++) //rapport.GetLength(1)
                {
                    sum += rapport[i, j];
                }
                Console.WriteLine($"Gemiddelde voor leerling {i} is {sum/toetsen}");
            }

            //gemiddelde per toets
            for (int i = 0; i < toetsen; i++)
            {
                int sum = 0;
                for (int j = 0; j < lln; j++)
                {
                    sum += rapport[j,i];
                }
                Console.WriteLine($"Gemiddelde voor toets {i} is {sum / lln}");
            }

        }
    }
}
