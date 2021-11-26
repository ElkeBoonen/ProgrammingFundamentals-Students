using System;
using System.Collections.Generic;

namespace TEST_CODEGRADE___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "aaabbcdddddddddddddde ++++ ABC _---";//Console.ReadLine();

            char[] array = input.ToCharArray();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (Char.IsLetterOrDigit(item))
                {
                    if (dic.ContainsKey(item))
                    {
                        dic[item]++;
                    }
                    else {
                        dic[item] = 1;
                    }
                }
            }

            int count = 0;
            foreach (var item in dic.Values)
            {
                if (item > 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            

        }
    }
}
