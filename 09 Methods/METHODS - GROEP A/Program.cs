using System;
using System.Collections.Generic;

namespace METHODS___GROEP_A
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
        static void Print(double[] array)
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
        static int MeestVoorkomend(int[] array)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 1);
                }
                else
                {
                    dictionary[item] += 1;
                }
            }
            int key = 0;
            int meeste = 0;
            foreach (var item in dictionary)
            {
                if (item.Value > meeste)
                {
                    meeste = item.Value;
                    key = item.Key;
                }
            }
            return key;
        }

        static int[] RandomVullen(int lengte = 10)
        {
            Random rd = new Random();
            int[] array = new int[lengte];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(1, 10);
            }
            return array;
            //Array.Sort(array); --> dode code!!! Nooit uitgevoerd!!!!
        }

        static int[] RandomVullen(int min, int max)
        {
            Random rd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(min, max);
            }
            return array;
        }

        static void Main(string[] args)
        {
            /*zonder static voor Print, moet je dit doen: 
             * Program pr = new Program();
             * pr.Print();
             */

            int[] array1 = { 1, 2, 6, 8, 6, 2, 3, 9, 8, 1, 1, 4, 8, 8, 5, 8, 8, 8, 9 };
            Print(array1);
            Console.WriteLine($"{MeestVoorkomend(array1)} komt het meeste voor!");

            int[] array2 = RandomVullen(10,10);
            Print(array2);
            int meest = MeestVoorkomend(array2);
            Console.WriteLine($"{meest} komt het meeste voor!");

            int[] array5 = RandomVullen(100);
            Print(array5);
            Console.WriteLine($"{MeestVoorkomend(array5)} komt het meeste voor!");

            int[] array6 = RandomVullen(); //optionele parameter!
            Print(array6);
            Console.WriteLine($"{MeestVoorkomend(array6)} komt het meeste voor!");

            int[] array7 = RandomVullen(-19,11);
            Print(array7);
            Console.WriteLine($"{MeestVoorkomend(array7)} komt het meeste voor!");

            double[] array3 = { 4.7, 5.1, 9.0 };
            Print(array3);
            string[] array4 = { "appel", "peer", "banaan", "kiwi" };
            Print(array4);

        }
    }
}
