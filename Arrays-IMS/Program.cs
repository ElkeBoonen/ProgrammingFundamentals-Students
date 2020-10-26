using System;
using System.Linq;

namespace Arrays_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam1 = "tuur";
            string naam2 = "jan";
            string naam3 = "mies";
            string naam4 = "bob";

            string[] namen = new string[4];
            namen[0] = naam1;
            namen[1] = naam2;
            namen[2] = naam3;
            namen[3] = naam4;

            int[] leeftijden = new int[]{ 13, 10, 9, 7 };
            leeftijden[1] = 11; //kan waarden array overschrijven

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i] + " is " + leeftijden[i] + " jaar oud");
            }

            Console.Write("Geef het aantal studenten: ");
            int aantal = Convert.ToInt32(Console.ReadLine()) ;
            string[] studenten = new string[aantal];
            for (int i = 0; i < aantal; i++)
            {
                Console.Write("Student " + (i+1) + ": "); //i++ != i+1 --> i++ == i=i+1
                studenten[i] = Console.ReadLine();
            }

            double[] punten = new double[aantal];
            for (int i = 0; i < aantal; i++)
            {
                Console.Write("Punten voor " + studenten[i] + ": ");
                punten[i] = Convert.ToDouble(Console.ReadLine());
            }

            double som = 0;
            foreach (double item in punten)
            {
                som += item; //som = som + item
            }
            Console.WriteLine("Som is " + som);
            double gem = Math.Round(som/aantal,1);          // som/punten.Length
            Console.WriteLine("Gemiddelde is " + gem);

            Console.WriteLine("Geef fruit in gescheiden door een spatie");
            string[] fruit = Console.ReadLine().Split(' ');
            foreach (string item in fruit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Geef aantal huisdieren in gescheiden door een spatie");
            string[] str_huisdieren = Console.ReadLine().Split(' ');
            int[] huisdieren = new int[str_huisdieren.Length];
            for (int i = 0; i < str_huisdieren.Length; i++)
            {
                huisdieren[i] = Convert.ToInt32(str_huisdieren[i]);
            }
            foreach (int item in huisdieren)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Geef temperaturen in gescheiden door een spatie");
            string[] str_temperaturen = Console.ReadLine().Split(' ');
            int[] temperaturen = Array.ConvertAll(str_temperaturen,Int32.Parse);
            foreach (int item in temperaturen)
            {
                Console.WriteLine(item);
            }
            
            int[] getallen = new int[10];
            Random willekeurig = new Random();
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = willekeurig.Next(0,100);
            }
            foreach (int item in getallen)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < getallen.Length; i++)
            {
                for (int j = 0; j < getallen.Length-1-i; j++)
                {
                    if (getallen[j] > getallen[j + 1])
                    {
                        int tijdelijk = getallen[j];
                        getallen[j] = getallen[j + 1];
                        getallen[j + 1] = tijdelijk;
                    }
                }
            }
            Console.WriteLine("\nGESORTEERD");
            foreach (int item in getallen)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nOMGEKEERD");
            Array.Reverse(getallen); //ook Sort!
            foreach (int item in getallen) 
            {
                Console.Write(item + " ");
            }
            
            int[,] nrs = new int[3, 4];
            nrs[0, 0] = 3;
            nrs[2, 2] = 3;
            nrs[1, 3] = 3;

            nrs = new int[,] { { 1, 2, 3, 4 },
                               { 5, 6, 7, 8},
                               { 9, 10, 11, 12} };

            Console.WriteLine("Totaal aantal elementen: " + nrs.Length); //rijen * kolommen;
            for (int i = 0; i < nrs.GetLength(0); i++) //3
            {
                for (int j = 0; j < nrs.GetLength(1); j++) //4
                {
                    Console.Write("Geef het element op positie " + i + "," + j + ": ");
                    nrs[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < nrs.GetLength(0); i++) //3
            {
                for (int j = 0; j < nrs.GetLength(1); j++) //4
                {
                    Console.Write(nrs[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            int totaal = 0;
            foreach (int item in nrs)
            {
                Console.Write(item + " ");
                totaal += item;
            }
            Console.WriteLine("Totaal: " + totaal);
            

            string[][] voetbal = new string[3][];
            voetbal[0] = new string[] { "jan", "piet", "joris", "korneel" };
            voetbal[1] = new string[] { "filip", "collin", "sven", "yves" };
            voetbal[2] = new string[] { "tristan", "charlie"};

            for (int i = 0; i < voetbal.GetLength(0); i++) 
            {
                for (int j = 0; j < voetbal[i].Length; j++) //geen getlength --> is niet gelijk!!!
                {
                    Console.Write(voetbal[i][j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < voetbal.GetLength(0); i++)
            {
                Console.Write((i+1) + " namen van spelers (spatie): ");
                voetbal[i] = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < voetbal.GetLength(0); i++)
            {
                for (int j = 0; j < voetbal[i].Length; j++) //geen getlength --> is niet gelijk!!!
                {
                    Console.Write(voetbal[i][j] + "\t");
                }
                Console.WriteLine();
            }

            string vak = "Programming Fundamentals";
            foreach (var item in vak)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            char[] vak_array = vak.ToCharArray();
            Array.Reverse(vak_array);
            for (int i = 0; i < vak_array.Length; i++)
            {
                Console.Write(vak_array[i]);
            }
            Console.WriteLine();
            Array.Sort(vak_array);
            for (int i = 0; i < vak_array.Length; i++)
            {
                Console.Write(vak_array[i]);
            }


        }
    }
}
