using System;
using System.IO;
using System.Linq;

namespace Files_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************************
             * writing to a file!!!!
             * ***********************/
            string filename = "file.txt";
            filename = @"C:\file.txt";
            filename = Path.Combine(@"C:\", "file.txt");

            //never use an absolute path!!! C: \Users\elkeb\OneDrive\Desktop
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename = Path.Combine(folder, "file.txt");

            StreamWriter output = File.CreateText(filename);
            output.WriteLine("1");
            output.WriteLine("2");
            output.WriteLine("3");
            output.Close();

            if (File.Exists(filename))
            {
                output = File.AppendText(filename);
                output.WriteLine("4");
                output.WriteLine("5");
                output.WriteLine("6");
                output.Close();
            }

            File.Delete(filename);


            /*************************
             * reading from a file!!!!
            *************************/
            Console.WriteLine("\n\n\nREAD TO END");
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            Console.WriteLine(text);
            input.Close();

            Console.WriteLine("\n\n\nREAD LINE BY LINE");
            input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();
            while (line != null)
            {
                Console.WriteLine("LINE : " + line);
                line = input.ReadLine(); //read the next line!!!!
            }
            input.Close();

            Console.WriteLine("\n\n\nREAD CHAR BY CHAR");
            input = File.OpenText("Rapunzel.txt");
            char c = (char)input.Read();
            while (!input.EndOfStream)
            {
                Console.Write(c + " ");
                c = (char)input.Read(); //read the next character!!!!
            }
            input.Close();

            Console.WriteLine("\n\n\nREAD CHAR BY CHAR -- FOR");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text.ElementAt(i) + " ");
            }

            Console.WriteLine("\n\n\nREAD CHAR BY CHAR -- FOREACH");
            foreach (var item in text)
            {
                Console.Write(item + " ");
            }
        }
    }
}
