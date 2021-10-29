using System;

namespace _1D_ARRAYS___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 5;

            int[] getallen = new int[3];
            string[] namen = { "tuur", "jan", "mies", "bob" };

            Console.WriteLine($"{getallen[0]} {getallen[1]} {getallen[2]}");
            Console.WriteLine($"{namen[0]} {namen[1]} {namen[2]} {namen[3]}");

            getallen[0] = 8;
            getallen[1] = getal;
            Console.WriteLine($"{getallen[0]} {getallen[1]} {getallen[2]}");

            Console.WriteLine(namen.Length);
            Console.WriteLine(namen);

            //namen[4] = "vijfde kind"; --> index out of range!

            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write(namen[i] + " ");
            }

            Console.WriteLine();
            foreach (var item in namen)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            foreach (string item in namen)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            int index = 0;
            while (index < namen.Length)
            {
                Console.Write(namen[index] + " ");
                index++; //niet vergeten!!!!
            }

            //punten ingeven!!!
            double[] punten;
            Console.WriteLine("\nGeef het aantal studenten in: ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            punten = new double[aantal];

            for (int i = 0; i < aantal; i++)
            {
                Console.Write($"Geef punt voor student {i+1}: ");
                //waarom gebruik je geen ++??
                //index zou hierdoor telkens met één verhoogd worden
                punten[i] = Convert.ToDouble(Console.ReadLine());
            }

            //punten af te drukken!!!
            Console.WriteLine();
            foreach (var item in punten)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nGeef een aantal stukken fruit in gescheiden door een komma");
            string[] fruit = Console.ReadLine().Split(',');
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGeef een aantal getallen in gescheiden door een spatie");
            string[] strGetallen = Console.ReadLine().Split(' ');
            int[] array = new int[strGetallen.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(strGetallen[i]);
            }
            int som = 0;
            foreach (var item in array)
            {
                som += item;
            }
            Console.WriteLine($"De som is {som}");

            //korte manier om alle getallen om te zetten
            //array = Array.ConvertAll(strGetallen, Convert.ToInt32);
            //array = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        }
    }
}
