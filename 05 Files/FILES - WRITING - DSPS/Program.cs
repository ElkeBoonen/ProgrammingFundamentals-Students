using System;
using System.IO;

namespace FILES___WRITING___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a file in your bin-folder! --> path = <project folder>\bin\Debug\<framework>
            StreamWriter writer = File.CreateText("file.txt");
            writer.WriteLine("This is my file");
            writer.WriteLine("testing 1 2 3");
            writer.WriteLine("test test test");
            writer.Close();

            //create a file and store in a folder on C-drive
            writer = File.CreateText(@"C:\test\file.txt");
            writer.WriteLine("test file");
            writer.Close();

            //create a file and put on the desktop
            string desktopfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopfolder, "file.txt");
            writer = File.CreateText(path);
            writer.WriteLine("test file");
            writer.Close();

            if (File.Exists(path))
            { 
                writer = File.AppendText(path);
                writer.WriteLine("testing 1 2 3");
                writer.WriteLine("test test test");
                writer.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                File.Delete(@"C:\test\file.txt");
            }

        }
    }
}
