using System;
using System.IO;

namespace INPUT___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INEENS ALLES LEZEN!!");
            StreamReader stream = File.OpenText("Rapunzel.txt");
            string text = stream.ReadToEnd();
            Console.WriteLine(text);
            stream.Close();

            Console.WriteLine("\n\nLIJN PER LIJN LEZEN - WHILE");
            stream = File.OpenText("Rapunzel.txt");
            string line;
            while (!stream.EndOfStream)
            {
                line = stream.ReadLine();
                Console.WriteLine("+++ " + line);
            }
            stream.Close();


            Console.WriteLine("\n\nLIJN PER LIJN LEZEN - DO WHILE");
            stream = File.OpenText("Rapunzel.txt");
            do
            {
                line = stream.ReadLine();
                Console.WriteLine("--- " + line);
            } while (line != null); //null is nada niks noppes ;)
            stream.Close();

            Console.WriteLine("\n\nCHAR PER CHAR");
            stream = File.OpenText("Rapunzel.txt");
            while (!stream.EndOfStream)
            {
                char c = (char)stream.Read();
                Console.Write(c + " ");
            }
            stream.Close();

            Console.WriteLine("\n\nCHAR PER CHAR - FOR EACH");
            stream = File.OpenText("Rapunzel.txt");
            text = stream.ReadToEnd();
            foreach (char c in text) //char c = var item
            {
                Console.Write(c + " ");
            }
            stream.Close();



        }
    }
}
