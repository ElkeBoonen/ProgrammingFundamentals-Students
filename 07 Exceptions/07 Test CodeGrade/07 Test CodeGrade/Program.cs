using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _07_Test_CodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.OpenText("donkey.txt").ReadToEnd().ToLower();
            string[] chars = Console.ReadLine().Split(' ');
            Regex regex = new Regex(chars[0] + @"\w*" + chars[1]);
            MatchCollection matches = regex.Matches(text);

            string[] words = new string[matches.Count];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = matches[i].Value;
            }

            Array.Sort(words);
            string word="";

            for (int i = 0; i < words.Length; i++)
            {
                if (word != words[i])
                {
                    Console.Write(words[i] + " ");
                    word = words[i];
                }
                
            }

        }
    }
}
