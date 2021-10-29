using System;
using System.IO;

namespace DONKEY___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText("donkey.txt");
            string text = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine("Geef een woord in: ");
            string woord = Console.ReadLine();

            text = text.Replace(woord, "");

            StreamWriter writer = File.CreateText("donkey.txt");
            writer.Write(text);
            writer.Close();

        
        }
    }
}
