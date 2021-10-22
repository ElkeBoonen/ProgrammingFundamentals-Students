using System;
using System.IO;
using System.Linq;

namespace INPUT___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //ik kan gewoon naam van file gebruiken omdat file 
            //gekopieerd wordt naar bin-folder!!!

            Console.WriteLine("INPUT - READ TO END!");
            StreamReader stream = File.OpenText("Rapunzel.txt");
            string text = stream.ReadToEnd();
            Console.WriteLine(text);
            stream.Close();

            Console.WriteLine("\n\nINPUT - READ LINE BY LINE - ENDOFSTREAM");
            stream = File.OpenText("Rapunzel.txt");
            while (!stream.EndOfStream)
            {
                string line = stream.ReadLine();
                Console.WriteLine("--- " + line);
            }
            stream.Close();

            Console.WriteLine("\n\nINPUT - READ LINE BY LINE - NULL");
            stream = File.OpenText("Rapunzel.txt");
            string lijn;
            do
            {
                lijn = stream.ReadLine();
                Console.WriteLine("+++ " + lijn);

            } while (lijn != null);
            stream.Close();

            Console.WriteLine("\n\nINPUT - READ CHAR BY CHAR");
            stream = File.OpenText("Rapunzel.txt");
            while (!stream.EndOfStream)
            {
                Console.Write((char)stream.Read() + " ");
            }
            stream.Close();

            Console.WriteLine("\n\nINPUT - READ CHAR BY CHAR - FOREACH");
            foreach (char item in text) //var item kan ook
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nINPUT - READ CHAR BY CHAR - FOR");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text.ElementAt(i) + " ");
            }
        }
    }
}
