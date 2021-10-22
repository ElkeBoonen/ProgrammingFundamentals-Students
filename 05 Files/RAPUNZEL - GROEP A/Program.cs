using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RAPUNZEL___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //hoe vaak komt 'rapunzel' voor in de tekst?
            StreamReader stream = File.OpenText("Rapunzel.txt");
            string text = stream.ReadToEnd().ToLower();
            stream.Close();

            int count = 0;
            string word = "";
            foreach (var item in text)
            {
                //if ((int)item >= 97 && (int)item <= 122)
                //if ("azertyuiopqsdfghjklmwxcvbn".Contains(item)) 
                //if (item == 'a' || item == 'b' || item == 'c' || ...)

                if (Char.IsLetter(item))
                {
                    word += item;
                }
                else {
                    if (word == "rapunzel") count++;
                    word = "";
                }
            }
            Console.WriteLine($"Rapunzel komt {count} keer voor in de tekst!");

            Regex regex = new Regex(@"rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"Rapunzel komt {matches.Count} keer voor in de tekst!");
         

            regex = new Regex(@"\w*ra\w*", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine($"{matches.Count} woorden met ra!");
            foreach (var item in matches)
            {
                Console.Write(item.ToString() + " ");
            }

        }
    }
}
