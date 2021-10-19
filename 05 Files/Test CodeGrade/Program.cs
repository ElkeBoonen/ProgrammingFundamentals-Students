using System;
using System.IO;

namespace Test_CodeGrade
{
    class Program
    {
        //Read in the file Harry Potter and the Sorcerer.txt 
        //Download Harry Potter and the Sorcerer.txt(already in CodeGrade) 
        //and read in a given number of lines.Write those lines
        //(with their line numbers) to another
        //file with the name harry-<nr of lines>.txt

        //input
        //12
        //output --> the textile harry-12.txt(open to see the result!)
        static void Main(string[] args)
        {
            string filename = @"Harry Potter and the Sorcerer.txt";
            StreamReader reader = File.OpenText(filename);

            int aantal = Convert.ToInt32(Console.ReadLine());

            StreamWriter writer = File.CreateText($"harry-{aantal}.txt");
            //StreamWriter writer = File.CreateText("harry-" + aantal+".txt");

            for (int i = 0; i < aantal ; i++)
            {
                string line = reader.ReadLine();
                writer.WriteLine(i + ": " + line);

                //writer.WriteLine($"{i}: {reader.ReadLine()}");
            }

            reader.Close();
            writer.Close();


        }
    }
}
