using System;
using System.Collections.Generic;

namespace Methods_DSPS
{
    class Program
    {
        static int[] numbers = { 4, 8, 5, 6, 7, 9, 1, 0, 4 };
        void CountOccurences()
        {
            /* We start from this text and output must be
               [c, 6] [o, 3] [u, 2]...
                Use dictionaries!
            */

            string text = "count the occurence of every character!";
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
                Console.WriteLine(item);
            }
        }

        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] words)
        {
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] Fill(int size=10)
        {
            int[] array = new int[size];
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-99,100); //incl lower - excl upperbound!
            }
            return array;

            Array.Sort(array); // dead code!!!!!!
        }

        static void FillRef(int[] array)
        {
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-99, 100); //incl lower - excl upperbound!
            }
        }

        static void ChangeValue(int value)
        {
            value = 100;
            Console.WriteLine(value);
        }

        static void ChangeValue(int[] array)
        {
            array[0] = 100;
            Print(array);
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("SWAP VALUE: " + a + " - " + b);
        }

        static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("SWAP REF: " + a + " - " + b);
        }

        static void SwapOut(out int a, out int b)
        {
            a = 500;
            b = 1000;

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("SWAP OUT: " + a + " - " + b);
        }

        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            Console.WriteLine(a + " - " + b);
            Swap(a, b);
            Console.WriteLine(a + " - " + b);
            SwapRef(ref a, ref b);
            Console.WriteLine(a + " - " + b);
            SwapOut(out a, out b);
            Console.WriteLine(a + " - " + b);

            Console.Write("Give a number: ");
            string answer = Console.ReadLine();
            int number;
            bool success = Int32.TryParse(answer, out number);

            Console.WriteLine("TRY PARSE " + success + " --> " + number);


            Console.WriteLine("\n\n");

            int x = 5;
            Console.WriteLine(x);
            ChangeValue(x);
            Console.WriteLine(x);

            int[] x_array = { 5 };
            Print(x_array);
            ChangeValue(x_array);
            Print(x_array);

            Program p = new Program();
            p.CountOccurences();

            Print(numbers);
            Array.Sort(numbers);
            Print(numbers);

            int[] nrs = { 4, 7, 1, 0, 0, -1, 5 };
            Print(nrs);

            int[] nrs1 = Fill(100);
            Print(nrs1);
            Array.Sort(nrs1);
            Print(nrs1);

            int[] nrs2 = Fill();
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);

            string[] words = { "banana", "apple", "lemon" };
            Print(words);
            Array.Sort(words);
            Print(words);

            double[] nrs3 = { 1.2, 5.5, 7, 0.1 };
            Print(nrs3);
            Array.Sort(nrs3);
            Print(nrs3);

            int[] nrs4 = new int[10];
            FillRef(nrs4);
            Print(nrs4);
            Array.Sort(nrs4);
            Print(nrs4);
        }
    }
}
