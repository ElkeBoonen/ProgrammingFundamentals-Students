using System;
using System.Collections.Generic;

namespace METHODS___GROEP_B
{
    class Program
    {
        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int Meest(int[] array)
        {            
            //tellen van zelfde items in array
            //meest voorkomende element eruit halen
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 1);
                }
                else
                {
                    //dictionary[item]++;
                    dictionary[item] += 1; //komt een extra keer voor!
                }
            }

            int meestvoorkomend = 0;
            int key = 0;
            foreach (var item in dictionary)
            {
                //Console.WriteLine(item);
                if (item.Value > meestvoorkomend)
                {
                    key = item.Key;
                    meestvoorkomend = item.Value;
                }
            }
            return key;
        }

        static int[] Vullen(int lengte, int min, int max)
        {
            int[] array = new int[lengte];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
            //Array.Sort(array); --> dode code --> unreachable!!!
        }

        static int[] Vullen(int lengte = 15)
        {
            int[] array = new int[lengte];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            return array;
            //Array.Sort(array); --> dode code --> unreachable!!!
        }

        static int[] Vullen(int min, int max)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
            //Array.Sort(array); --> dode code --> unreachable!!!
        }

        static void Main(string[] args)
        {
            /*
             * Als we werken zonder static bij methode definitie 
             * Program pr = new Program();
             * pr.Print();
             */

            int[] array1 = { 1, 3, 1, 4, 6, 2, 3, 3, 3, 9, 7, 8, 6, 2, 5 };
            Print(array1);
            Array.Sort(array1);
            Print(array1);
            int waarde = Meest(array1);
            Console.WriteLine($"{waarde} komt het meeste voor in array1!");

            Console.WriteLine("Geef een lengte van de array in");
            int lengte = Convert.ToInt32(Console.ReadLine());
            int[] array2 = Vullen(lengte, 1, 10);
            Print(array2);
            Array.Reverse(array2);
            Print(array2);
            Console.WriteLine($"{Meest(array2)} komt het meeste voor in array2!");

            int[] array3 = Vullen();
            Print(array3);
            Console.WriteLine($"{Meest(array3)} komt het meeste voor in array3!");

            int[] array4 = Vullen(30);
            Print(array4);
            Console.WriteLine($"{Meest(array4)} komt het meeste voor in array4!");

            int[] array5 = Vullen(-10,10);
            Print(array5);
            Console.WriteLine($"{Meest(array5)} komt het meeste voor in array5!");

            string[] array6 = { "jan", "piet", "joris", "korneel" };
            Print(array6);

            double[] array7 = { 6.5, 1.2, 3.4, 9.0, 6 };
            Print(array7);

        }
    }
}
