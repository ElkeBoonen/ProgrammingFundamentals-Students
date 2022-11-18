using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DSPS___Zorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();

            string text = File.ReadAllText(filename).ToLower();
            Regex regex = new Regex(@"\b[a-z]+\b");
            MatchCollection matches = regex.Matches(text);

            string output = "";
            foreach (Match item in matches)
            {
                if (item.Value.Contains('z'))  //&& !output.Contains(item.Value) is doing the trick when we don't have zip and zipper ;)
                {
                    regex = new Regex(@"\b" + item.Value + @"\b");
                    if (regex.Matches(output).Count == 0) output += item.Value + " ";
                }

            }
            Console.WriteLine(output);
        }
    }
}
