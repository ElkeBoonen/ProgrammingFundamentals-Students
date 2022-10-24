using System;
using System.IO;

namespace DONKEY___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord in: ");
            string word = Console.ReadLine();

            string text = File.ReadAllText("donkey.txt");
            text = text.ToLower().Replace(word, "");

            File.WriteAllText($"donkey-{word}.txt", text);
        }
    }
}
