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

        static int MeestVoorkomend(int[] array)
        {            
            //tellen van zelfde items in array
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

        static void Main(string[] args)
        {
            /*
             * Als we werken zonder static bij methode definitie 
             * Program pr = new Program();
             * pr.Print();
             */

            int[] array1 = { 1, 3, 1, 4, 6, 2, 3, 3, 3, 9, 7, 8, 6, 2, 5 };
            int[] array2 = { 1, 2, 3, 4, 5 };

            Print(array1);
            Array.Sort(array1);
            Print(array1);

            Print(array2);
            Array.Reverse(array2);
            Print(array2);

            int waarde = MeestVoorkomend(array1);
            Console.WriteLine($"{waarde} komt het meeste voor in array1!");
        }
    }
}
