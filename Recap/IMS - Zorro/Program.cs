using System;
using System.IO;
using System.Text.RegularExpressions;

namespace IMS___Zorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("ColdPlay.txt").ToLower();
            Regex regex = new Regex(@"\b[a-z]+\b");

            string output = "";

            foreach (Match item in regex.Matches(text))
            {
                if (item.Value.Contains('z'))
                {
                    regex = new Regex(@"\b" + item.Value + @"\b");
                    if (regex.Matches(output).Count == 0)
                    {
                        output += item.Value + " ";
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
