using System;
using System.Collections.Generic;

namespace _08_Test_CodeGrade
{
    class Program
    {
        /*
         Read in a string and return the number of alphanumeric characters that occur more than once.

            input
            abcde
            output
            0

            input
            aabbcde
            output
            2         
         */
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            string input = Console.ReadLine();
            //regex [a-zA-z0-9]
            foreach (char item in input)
            {
                if (Char.IsLetterOrDigit(item))
                {
                    if (dictionary.ContainsKey(item))
                    {
                        dictionary[item]++;
                    }
                    else
                    {
                        dictionary[item] = 1;
                    }
                }
                
            }
            int count = 0;
            foreach (var item in dictionary.Values)
            {
                if (item > 1) count++;
            }
            Console.WriteLine(count);
        }
    }
}
