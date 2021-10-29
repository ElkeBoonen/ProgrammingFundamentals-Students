using System;

namespace TEST_CODEGRADE___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to find maximum and minimum elements in an array. 

                input
                1 5 8 10 5 6 9 10

                output
                Maximum is 10
                Minimum is 1
            */

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            int min = array[0];
            int max = array[0]; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            Console.WriteLine($"Maximum is {max}");
            Console.WriteLine($"Minimum is {min}");

            //alterantief is om te sorteren
            Array.Sort(array);
            Console.WriteLine($"Maximum is {array[array.Length-1]}");
            Console.WriteLine($"Minimum is {array[0]}");


        }
    }
}
