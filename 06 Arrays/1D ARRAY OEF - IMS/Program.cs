using System;

namespace _1D_ARRAY_OEF___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 7, -1, 10, 4, 21 };

            //som & gemiddelde berekenen
            double sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            Console.WriteLine("som = " + sum);
            Console.WriteLine("gemiddelde = " + (sum/array.Length).ToString("0.000"));

            //minimum eruit halen
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("min = " + min);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

        }
    }
}
