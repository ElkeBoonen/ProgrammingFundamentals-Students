using System;
using System.IO;

namespace HARRY_POTTER___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een aantal lijnen in: ");
            int count = Convert.ToInt32(Console.ReadLine());

            StreamReader reader = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter writer = File.CreateText($"harry-{count}.txt");
            int line = 0;
            while (line < count && !reader.EndOfStream)
            {
                writer.WriteLine(reader.ReadLine());
                line++;
            }

            //for (int i = 0; i < count && !reader.EndOfStream; i++)
            //{
            //    writer.WriteLine(reader.ReadLine());
            //}

            reader.Close();
            writer.Close();

        }
    }
}
