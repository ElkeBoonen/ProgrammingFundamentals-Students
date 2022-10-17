using System;
using System.IO;
using System.Text.RegularExpressions;

namespace HARRY_POTTER___CHARACTERS___DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int first = item.IndexOf(';');
                    string substring = item.Substring(first+1);
                    int second = substring.IndexOf(';');
                    Console.WriteLine(substring.Substring(0,second));
                }
            }

            Regex regex = new Regex(@"[0-9]{4}");
            MatchCollection matches = regex.Matches(File.ReadAllText("Characters.csv"));
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
