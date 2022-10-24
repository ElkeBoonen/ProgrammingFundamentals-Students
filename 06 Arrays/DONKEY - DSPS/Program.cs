using System;
using System.IO;

namespace DONKEY___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string text = File.ReadAllText("donkey.txt");
            text = text.ToLower().Replace(word, "");

            File.WriteAllText("donkey.txt", text);
        }
    }
}
