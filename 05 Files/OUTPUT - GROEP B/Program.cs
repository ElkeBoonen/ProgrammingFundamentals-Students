using System;
using System.IO;

namespace OUTPUT___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 verschillende opties om een file aan te maken

            //deze komt in bin-folder
            //StreamWriter stream = File.CreateText("File.txt");

            //deze komt op C-schijf
            /*string path = Path.Combine(@"C:\", "file.txt");
            StreamWriter stream = File.CreateText(path);*/

            //deze komt op desktop
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(folder, "file.txt");

            //dit is om file te creëren
            StreamWriter stream = File.CreateText(path);
            stream.WriteLine("Dit is een test!");
            stream.WriteLine("Dit is een test!");
            stream.WriteLine("Dit is een test!");
            stream.Close();

            //tekst toevoegen en checken of file bestaat
            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("Dit is een test 1234567890!");
                stream.WriteLine("Dit is een test 1234567890!");
                stream.WriteLine("Dit is een test 1234567890!");
                stream.Close();
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }




        }
    }
}
