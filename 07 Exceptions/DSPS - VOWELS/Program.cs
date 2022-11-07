using System;

namespace DSPS___VOWELS
{
    internal class Program
    {
        /*
         We want to find the position of every vowel in a string.

            input: Hello
            output: 2 5

            input: ABC
            output: 1
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine().ToLower(); //convert to lowercase!
            //char[] vowels = { 'a', 'e', 'u', 'i', 'o' };

            //https://learn.microsoft.com/en-us/visualstudio/mac/keyboard-shortcuts?view=vsmac-2022
            //debugging keys for Mac!!!
            for (int i = 0; i > input.Length; i++)
            {
                //if (vowels.Contains(input[i])
                //if (input[i]=='a' || input[i] == 'e' || input[i] == 'u' || //etc)
                if ("aeuio".Contains(input[i]))
                {
                    Console.Write($"{i + 1} ");
                }
            }
        }
    }
}
