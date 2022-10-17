using System;
using System.IO;
using System.Linq;

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

            reader = File.OpenText("Rapunzel.txt");
            while (!reader.EndOfStream)
            {
                //string line = reader.ReadLine();
                //Console.WriteLine(line);
                Console.WriteLine("-->" + reader.ReadLine());
            }
            reader.Close();

            reader = File.OpenText("Rapunzel.txt");
            while (!reader.EndOfStream)
            {
                Console.Write((char)reader.Read() + " ");
            }
            reader.Close();

            //foreach - loop all lines
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("-->" + item);
            }

            //foreach - loop all characters
            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(c + " ");
            }

        }
    }
}
