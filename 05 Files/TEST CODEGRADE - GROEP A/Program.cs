using System;
using System.IO;

namespace TEST_CODEGRADE___GROEP_A
{
    class Program
    {
        /*Read in the file Harry Potter and the Sorcerer.txt  
         * Read in a given number of lines. Write those lines (with their line numbers) to another 
         * file with the name harry-<nr of lines>.txt
         * input: 12
         * output: the textile harry-12.txt (open to see the result!) 
         */

        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText(@"Harry.txt");
            int count = Convert.ToInt32(Console.ReadLine());
            StreamWriter writer = File.CreateText("harry-" + count + ".txt");

            for (int i = 0; i < count; i++)
            {
                string line = reader.ReadLine();
                writer.WriteLine(i + ": " + line);
            }

            reader.Close();
            writer.Close();

        }
    }
}
