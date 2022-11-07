using System;
using System.Collections.Immutable;
using System.IO;
using System.Text.RegularExpressions;

namespace DSPS___DONKEY
{
    internal class Program
    {
        /*
        The goal of the project is to read in a file donkey.txt and to find all words 
        (in a unique sequence) that start and end with a given character. 
        If a non alphabetic character was entered you output 'crazy output'! 

        input
        d y
        output
        day delivery difficulty donkey
         */
        static void Main(string[] args)
        {
            //d y --> read this
            //012 -> indices
            string chars = Console.ReadLine().Trim(); //removing spaces before and after
            char start = chars[0]; //chars[1] --> space
            char end = chars[2];

            string filename = Console.ReadLine();

            //regex from https://regexr.com/ --> \bd[a-z]*y\b
            //Regex regex = new Regex(@"\b" + start + "[a-z]*" + end + @"\b");
            Regex regex = new Regex($"\\b{start}[a-z]*{end}\\b");


            string unique = "";
            MatchCollection matches = regex.Matches(File.ReadAllText(filename));
            foreach (Match match in matches)
            {
                if (!unique.Contains(match.Value))
                {
                    unique += match.Value + ":";
                }
            }

            string[] words = unique.Split(':');
            Array.Sort(words);
            Console.WriteLine(String.Join(" ",words));

            //if you don't have a split
            regex = new Regex(":");
            matches = regex.Matches(unique);

            words = new string[matches.Count];
            string word = "";
            int index = 0;
            foreach (var item in unique)
            {
                if (item != ':')
                {
                    word += item;
                }
                else
                {
                    words[index] = word;
                    index++;
                    word = "";
                }
            }
            Array.Sort(words);
            Console.WriteLine(String.Join(" ", words));

        }
    }
}
