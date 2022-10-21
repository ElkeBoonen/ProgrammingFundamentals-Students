using System;
using System.IO; //altijd als je met files werkt System.IO importeren!!!
using System.Text.RegularExpressions;

namespace RAPUNZEL___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("Rapunzel.txt");

            //juist dezelfde methode!
            //StreamReader sr = File.OpenText("Rapunzel.txt");
            //string text = sr.ReadToEnd();
            //sr.Close();

            Console.WriteLine("Aantal karakters: " + text.Length);

            /***********/
            /* AANTAL A*/
            /***********/

            int count = 0;
            //karakters checken! --> FOR-LOOP
            for (int i = 0; i < text.Length; i++)
            {
                //if ("aA".Contains(text[i])
                if (text[i] == 'a' || text[i] == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine("Aantal a's: " + count);

            count = 0;
            //karakters checken! --> FOREACH
            //zet volledige tekst om naar kleine letters!
            foreach (var item in text.ToLower())
            {
                if (item == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine("Aantal a's: " + count);

            count = 0;
            //karakters checken! --> WHILE
            StreamReader sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                int c = sr.Read();
                if (c==65 || c==97)
                {
                    count++;
                }
            }
            sr.Close();
            Console.WriteLine("Aantal a's: " + count);

            //REGEX
            Regex regex = new Regex(@"[aA]"); //andere regex: (a|A)
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine("Aantal a's: " + matches.Count);


            /******************/
            /* AANTAL WOORDEN */
            /******************/
            count = 0;
            foreach (var item in text.ToLower())
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Aantal woorden: " + count);

            regex = new Regex(@"\w+");
            matches = regex.Matches(text);
            Console.WriteLine("Aantal woorden: " + matches.Count);


            /*******************/
            /* AANTAL RAPUNZEL */
            /*******************/
            count = 0;
            string word = "";

            foreach (char item in text.ToLower())
            {
                if ("azertyuiopqsdfghjklmwxcvbn".Contains(item))
                {
                    word += item;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        count++;
                    }
                    word = "";

                }
            }
            Console.WriteLine("Aantal Rapunzel: " + count);

            //\bRapunzel|RAPUNZEL|rapunzel\b
            regex = new Regex(@"\brapunzel\b",RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine("Aantal Rapunzel: " + matches.Count);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
