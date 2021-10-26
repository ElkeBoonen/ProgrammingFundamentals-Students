using System;
using System.IO;

namespace DONKEY___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een te vervangen woord in: ");
            string value = Console.ReadLine();

            StreamReader reader = File.OpenText("donkey.txt");
            string tekst = reader.ReadToEnd();
            tekst = tekst.Replace(value, "");
            reader.Close();

            StreamWriter writer = File.CreateText("donkey.txt");
            writer.WriteLine(tekst);
            writer.Close();

        }
    }
}
