using System;
using System.IO;

namespace OUTPUT___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //komt in BIN-folder
            //StreamWriter stream = File.CreateText("file.txt");

            //komt in folder die je hebt meegegeven!
            //let op @ voor filepath
            //StreamWriter stream = File.CreateText(@"C:\test\file.txt");

            //komt op desktop!!
            //let op combineren van folder- en filepath!
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = Path.Combine(folderpath, "file.txt");
            StreamWriter stream = File.CreateText(filepath);

            stream.WriteLine("Hallo dit is een test");
            stream.WriteLine("Hallo dit is een test");
            stream.WriteLine("Hallo dit is een test");
            stream.Close();

            if (File.Exists(filepath))
            {
                stream = File.AppendText(filepath);
                stream.WriteLine("toevoegen");
                stream.WriteLine("toevoegen");
                stream.WriteLine("toevoegen");
                stream.Close();
            }

            if (File.Exists(filepath))
            {
                Console.WriteLine("Wil je deze file verwijderen (ja/nee)?");
                if (Console.ReadLine() == "ja")
                {
                    File.Delete(filepath);
                }
            }
        }
    }
}
