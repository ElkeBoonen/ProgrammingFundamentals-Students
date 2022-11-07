using System;
using System.IO;
using System.Text.RegularExpressions;

namespace IMS___DONKEY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 2 karakters in: ");
            string chars = Console.ReadLine(); //d y

            char start = chars[0]; //chars[1] is de spatie
            char end = chars[2];

            Regex regex = new Regex(@"\b"+start+@"\w+"+end+@"\b");
            MatchCollection matches = regex.Matches(File.ReadAllText("donkey.txt"));

            string result = "";
            foreach (Match match in matches)
            {
                if (!result.Contains(match.Value)) result += " " + match.Value;
            }
        }
    }
}
