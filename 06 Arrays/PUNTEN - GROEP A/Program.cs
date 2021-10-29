using System;

namespace PUNTEN___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een reeks punten in gescheiden door spatie");
            //8 7 -1 10 -6 9 3 12 -7 7
            double[] punten = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToDouble);

            double min = punten[0];
            foreach (var item in punten)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"Het minimum is: {min}");

            for (int i = 0; i < punten.Length; i++)
            {
                for (int j = 0; j < punten.Length-1; j++)
                {
                    if (punten[j] > punten[j + 1])
                    {
                        double swap = punten[j];
                        punten[j] = punten[j + 1];
                        punten[j + 1] = swap;
                    }

                }
            }
            Console.WriteLine($"Gesorteerde rij");
            foreach (var item in punten)
            {
                Console.Write(item + " ");
            }

            double som = 0;
            foreach (var item in punten)
            {
                som += item; //som = som + item;
            }
            Console.WriteLine($"\nDe som is: {som}");
            Console.WriteLine($"Het gemiddelde is: {som/punten.Length}");

        }
    }
}
