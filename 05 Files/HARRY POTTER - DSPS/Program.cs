using System;
using System.IO;

namespace HARRY_POTTER___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of lines: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            StreamWriter sr = File.CreateText($"harry-{lines}.txt");
            foreach (string line in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (count <= lines)
                {
                    sr.WriteLine(count + " " + line);
                    count++;
                }
                else break; //break will stop the foreach
            }
            sr.Close();

            count = 0;
            StreamReader read = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter write = File.CreateText($"harry-{lines}-option2.txt");
            while (count <= lines)
            {
                write.WriteLine(count + " " + read.ReadLine());
                count++;
            }
            read.Close();
            write.Close();

        }
    }
}
