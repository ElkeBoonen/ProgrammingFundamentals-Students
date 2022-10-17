using System;
using System.IO;

namespace FILES___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file wordt gemaakt in BIN-folder --> <projectfolder>\bin\Debug\netcoreapp3.1
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("Voila, hier ben ik!");
            stream.WriteLine("Nog een regeltje in de file!");
            stream.Close();

            //file maken op de C-schijf
            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("Voila, hier ben ik!");
            stream.WriteLine("Nog een regeltje in de file!");
            stream.Close();

            //file maken op de desktop
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"file.txt");
            stream = File.CreateText(path);
            stream.WriteLine("Voila, hier ben ik!");
            stream.WriteLine("Nog een regeltje in de file!");
            stream.Close();

            //CreateText zal altijd overschrijven
            //AppendText zal toevoegen
            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("Voila, hier ben ik!");
                stream.WriteLine("Nog een regeltje in de file!");
                stream.Close();
            }

            //file verwijderen
            if (File.Exists(@"C:\test\file.txt"))
            {
                File.Delete(@"C:\test\file.txt");
            }

            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd(); //File.ReadAllText
            input.Close(); // altijd file sluiten!!!!!
            Console.WriteLine(text);

            //lezen lijn per lijn!
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            { 
                Console.WriteLine("-->" + input.ReadLine());
            }
            input.Close();

            //lezen char per char
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read()+" "); //ASCII waarden, casten naar char
            }
            input.Close();

            //foreach gebruiken als je over reeks of collectie wilt lopen!!!
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("**** " + item);
            }

            foreach (char item in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(item + " ");
            }

            foreach (char karakter in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(karakter);
            }
        }
    }
}
