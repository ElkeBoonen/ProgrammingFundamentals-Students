using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace DSPS___Yellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //converting hexcolor to colorname
                string hexcolor = Console.ReadLine();
                int hexnumber = Convert.ToInt32(hexcolor, 16);
                Color myColor = ColorTranslator.FromOle(hexnumber);

                if (!myColor.IsKnownColor)
                {
                    Console.WriteLine("Colorless");
                    return;
                    //throw new Exception();
                }
                //else
                //{ }

                //reading the file
                string text = File.ReadAllText("ColdPlay.txt");

                //StreamReader read = File.OpenText("ColdPlay.txt");
                //string text = read.ReadToEnd();
                //read.Close();

                //Console.WriteLine(myColor.Name);
                Regex regex = new Regex(@"\b" + myColor.Name + @"\b", RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(text);

                if (matches.Count > 0) Console.WriteLine($"It was all {myColor.Name} ({matches.Count})");
                else Console.WriteLine($"It was not ({myColor.Name})");
            }
            catch (FormatException) { Console.WriteLine("Wrong input!");  }




        }
    }
}
