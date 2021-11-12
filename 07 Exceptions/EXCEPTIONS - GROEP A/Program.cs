using System;
using System.IO;

namespace EXCEPTIONS___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef aantal lijnen in: ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een filenaam in: ");
            string filenaam = Console.ReadLine();

            StreamReader stream = File.OpenText(filenaam);
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine(stream.ReadLine());
            }
            stream.Close();
        }
    }
}
