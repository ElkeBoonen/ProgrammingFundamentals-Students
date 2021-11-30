using System;
using System.Collections.Generic;

namespace METHODS___GROEP_B
{
    class Program
    {
        static int[] array = { 1, 3, 1, 4, 6, 2, 3, 3, 3, 9, 7, 8, 6, 2, 5 };

        static void Print()
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /*
             * Als we werken zonder static bij methode definitie 
             * Program pr = new Program();
             * pr.Print();
             */

            Print();

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
                Console.WriteLine(item);
                if (item.Value > meestvoorkomend)
                {
                    key = item.Key;
                    meestvoorkomend = item.Value;
                }
            }

            Console.WriteLine($"{key} komt het meeste voor!");
        }
    }
}
