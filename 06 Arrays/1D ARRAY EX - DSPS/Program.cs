using System;
using System.Linq;

namespace _1D_ARRAY_EX___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, -3, 6, 9, 2, 3, -4, 5 };

            //easy way 
            Console.WriteLine("sum : " + array.Sum());
            Console.WriteLine("min : " + array.Min());
            Console.WriteLine("average : " + array.Average());
            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //algorithmic way
            //creating sum & average

            array = new int[] { 1, 8, -3, 6, 9, 2, 3, -4, 5 }; //to get the original order back, overwrite the elements

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                //sum = sum + array[i]
            }
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("average : " + sum/array.Length);

            //find the minimum
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("min : " + min);

            //sorting algorithm
            //https://en.wikipedia.org/wiki/Bubble_sort
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
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
            Console.WriteLine();
        }
    }
}
