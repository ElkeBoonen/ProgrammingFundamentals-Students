using System;
using System.IO;

namespace FILES___READING___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText("Rapunzel.txt");
            string text = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(text);
        }
    }
}
