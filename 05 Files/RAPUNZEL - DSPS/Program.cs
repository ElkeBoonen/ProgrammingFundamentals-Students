using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RAPUNZEL___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opening a file and reading all content
            //StreamReader sr = File.OpenText("Rapunzel.txt");
            //string text = sr.ReadToEnd();
            //sr.Close();

            //opening a file and reading all content
            //other 'version'
            string text = File.ReadAllText("Rapunzel.txt");
            
            //count characters
            Console.WriteLine("# chars: " + text.Length);

            //count lines
            Console.WriteLine("# lines: " + File.ReadAllLines("Rapunzel.txt").Length);

            //count lines, other 'version'
            //reading in all lines with a WHILE!
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;        //count lines!
            }
            sr.Close();
            Console.WriteLine("# lines: " + lines);


            //count the A/a's! 
            //version while
            int countA = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                /*if ("aA".Contains(c))
                {
                    countA++;
                }*/
                if (c == 'a' || c == 'A')
                {
                    countA++;
                }
            }
            sr.Close();
            Console.WriteLine($"# A's: {countA}");


            //version foreach
            countA = 0;
            foreach (char item in text.ToLower()) //text = File.ReadAllText("Rapunzel.txt");
            {
                if (item == 'a')
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's: {countA}");


            //version for
            countA = 0;
            for (int i = 0; i < text.Length; i++)
            {
                //if (text.ElementAt(i) == 65 || text.ElementAt(i) == 97)
                if (text[i] == 65 || text[i] == 97) //using the ASCII values
                {
                    countA++;
                }
            }
            Console.WriteLine($"# A's: {countA}");

            //count words - foreach
            int countwords = 0;
            foreach (char item in text)
            {
                if (item == ' ')
                {
                    countwords++;
                }
            }
            Console.WriteLine("#words: " + countwords);

            //count words - foreach
            countwords = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if (!"azertyuiopqsdfghjklmwxcvbn".Contains(Char.ToLower(c)))
                {
                    if (c != '\'')
                    {
                        countwords++;
                    } 
                }
            }
            Console.WriteLine("#words: " + countwords);

            //rapunzel
            string word = "";
            int countRapunzel = 0;
            foreach (char c in text.ToLower())
            {
                if ("azertyuiopqsdfghjklmwxcvbn".Contains(c))
                {
                    word += c;
                }
                else 
                {
                    if (word == "rapunzel")
                    {
                        countRapunzel++;
                    }
                    word = "";
                }        
            }
            Console.WriteLine("# rapunzel: " + countRapunzel);

            //WORKING WITH REGEX
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            //Regex regex = new Regex("Rapunzel|RAPUNZEL|rapunzel");
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine("# rapunzel: " + matches.Count);

            regex = new Regex(@"\w+", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine("# words: " + matches.Count);



        }
    }
}
