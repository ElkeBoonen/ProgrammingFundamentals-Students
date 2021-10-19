using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RAPUNZEL___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = File.OpenText("Rapunzel.txt");

            //aantal keer rapunzel tellen!
            string text = stream.ReadToEnd().ToLower();
            string woord = "";
            int teller = 0;

            foreach (var item in text)
            {
                //check karakter is alfabetisch!!
                //"abcdefghijklmnopqrstuvwxyz".Contains(item)
                //Char.IsLetter(item)
                //(int)item >= 97 && (int)item <= 122 ASCII tabel waarde gebruiken
                //item =='a' || item == 'b' || item == 'c' ...

                if (Char.IsLetter(item))
                {
                    woord += item; // woord= woord + item (item aan toevoegen) 
                }
                else {
                    if (woord == "rapunzel")
                    {
                        teller++; // teller = teller +1
                    }
                    woord = "";
                }
            }
            Console.WriteLine($"Rapunzel komt {teller} keer voor in de file!");

            Regex regex = new Regex(@"Rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"Rapunzel komt {matches.Count} keer voor in de file!");

        }
    }
}
