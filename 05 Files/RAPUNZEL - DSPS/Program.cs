using System;
using System.IO;

namespace RAPUNZEL___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader sr = File.OpenText("Rapunzel.txt");
            //string text = sr.ReadToEnd();
            //sr.Close();

            string text = File.ReadAllText("Rapunzel.txt");
            Console.WriteLine("# chars: " + text.Length);

            Console.WriteLine("# lines: " + File.ReadAllLines("Rapunzel.txt").Length);

            //reading in all lines with a WHILE!
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();
            Console.WriteLine("# lines: " + lines);

            //count the A/a's! 
            //while
            //foreach
            //for

        }
    }
}
