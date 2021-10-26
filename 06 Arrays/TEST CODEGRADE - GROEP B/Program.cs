using System;

namespace TEST_CODEGRADE___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to find maximum and minimum elements in an array. 
                input
                1 5 8 10 5 6 9 1

                output
                Maximum is 10
                Minimum is 1*/

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            int min = array[0];
            int max = array[0];
            foreach (var item in array)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            Console.WriteLine($"Maximum is {max}");
            Console.WriteLine($"Minimum is {min}");


        }
    }
}
