using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string desktop = Path.Combine(folder, "file.txt");
            //StreamWriter stream = File.CreateText("file.txt"); --> file will end up in debug-folder!!
            //StreamWriter stream = File.CreateText(desktop); --> file will end up on the desktop

            string path = Path.Combine(@"C:\", "file.txt");
            //StreamWriter stream = File.CreateText(path); // --> exception! 

            Console.WriteLine("CREATE FILE");
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("-----  This is a test!!!");
            stream.Close();
            Console.WriteLine("APPEND TEXT");
            stream = File.AppendText("file.txt");
            stream.WriteLine("This is a test!!!");
            stream.Close();

            Console.WriteLine("DELETE FILE");
            //Delete file
            if (File.Exists(desktop))
            {
                File.Delete(desktop);
            }

            //Read file --> to end!
            Console.WriteLine("\nREAD RAPUNZEL --> TOEND");
            StreamReader reader = File.OpenText("Rapunzel.txt");
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
            Console.WriteLine("NEXT LINE= " + reader.ReadLine());
            reader.Close();

            Console.WriteLine("\nREAD RAPUNZEL --> LINE BY LINE");
            //Read file --> line by line
            reader = File.OpenText("Rapunzel.txt");
            string line = reader.ReadLine();
            while (line != null) //!reader.EndOfStream
            {
                Console.WriteLine("LINE: " + line);
                line = reader.ReadLine();
            }
            reader.Close();

            Console.WriteLine("\nREAD RAPUNZEL --> CHAR BY CHAR");
            //Read file --> line by line
            reader = File.OpenText("Rapunzel.txt");
            int ascii = reader.Read();
            while (!reader.EndOfStream)
            {
                Console.Write((char)ascii + " ");
                ascii = reader.Read();
            }
            reader.Close();

            Console.WriteLine("\nREAD RAPUNZEL --> CHAR BY CHAR -- FOREACH");
            foreach (char item in text) //I created text on line 37!!
            {
                Console.Write(item + " ");
            }

        }
    }
}
