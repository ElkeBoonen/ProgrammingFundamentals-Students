using System;

namespace IMS___In_the_mix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            string mix = "";
            if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    mix += word1[i];
                    if (i < word2.Length) mix += word2[i];
                }
            }
            else //word 2 is langer
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    mix += word2[i];
                    if (i < word1.Length) mix += word1[i];
                }
            }

            Console.WriteLine(mix);
        }
    }
}
