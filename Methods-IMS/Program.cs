using System;
using System.Collections.Generic;

namespace Methods_IMS
{
    class Program
    {
        //statische variable
        static int[] statische_array = { 4, 5, 8, 7, 1 };
        static void HerhalingsOef()
        {
            //oef uit herhaling
            string text = "count the occurence of every character!";
            //[c, 6] [o, 3] [u, 2] [n, 2] [t, 3] [ , 5] [h, 2] [e, 6] [r, 4] [f, 1] [v, 1] [y, 1] [a, 2] [!, 1]

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else dict[c] = 1;
            }

            foreach (var item in dict)
            {
                Console.Write(item + " ");
            }
        }

        static void Print(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] array)
        {
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] RandomFill(int size = 10)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
            }
            return array;

            Array.Sort(array); //wordt noooooooooit uitgevoerd!!!!!!
        }

        static void ChangeValue(int x)
        {
            x = 100;
            Console.WriteLine(x);
        }

        static void ChangeValue(int[] x)
        {
            x[0] = 100;
            Print(x);
        }



        static void Main(string[] args)
        {
            //x is een integer --> simple datatype = value type
            int x = 1;
            Console.WriteLine(x);
            ChangeValue(x);
            Console.WriteLine(x);

            //x_array is een array --> complex datatype = reference type
            int[] x_array = { 1 }; 
            Print(x_array);
            ChangeValue(x_array);
            Print(x_array);


            int[] array = { 4, 7, 8, 1, 2, 6, 0 };
            Print(array);
            Array.Sort(array);
            Print(array);

            int[] array1 = RandomFill(30);
            Print(array1);
            Array.Sort(array1);
            Print(array1);

            int length = 20;
            int[] array2 = RandomFill(length);
            Print(array2);
            Array.Sort(array2);
            Print(array2);

            int[] array3 = RandomFill();
            Print(array3);
            Array.Sort(array3);
            Print(array3);

            string[] words = { "appel", "peer", "banaan" };
            Print(words);
            Array.Sort(words);
            Print(words);

            double[] dbl = { 1.2, 4, 5.9, 0.5, 8.0 };
            Print(dbl);
            Array.Sort(dbl);
            Print(dbl);

          

        }
    }
}
