using System;
using System.Collections.Generic;
using System.Linq;

namespace Feedback_07_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 3 4 5 7 8 9 10
            string answer = Console.ReadLine();
            string[] array = answer.Split(' ');
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int[] int_array = new int[array.Length];
            for (int i = 0; i < int_array.Length; i++)
            {
                int_array[i] = Convert.ToInt32(array[i]);
            }
            foreach (var item in int_array)
            {
                Console.WriteLine(item);
            }

            int[] int_array1 = Array.ConvertAll(array, Int32.Parse);
            foreach (var item in int_array1)
            {
                Console.WriteLine(item);
            }

            List<int> int_list = int_array.ToList();

            List<int> int_List1 = new List<int>();
            int_List1.AddRange(int_array);

            //dictionary 
            //pineapple pear citron banana pineapple peach peach kiwi mandarin pineapple cherry pear pear citron
            answer = Console.ReadLine();
            string[] fruit = answer.Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in fruit)
            {
                if (!dict.ContainsKey(item)) dict.Add(item, 1);
                else dict[item]++;
            }

        }
    }
}
