using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _07_Test_CodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.OpenText("donkey.txt").ReadToEnd().ToLower();
            string[] chars = Console.ReadLine().ToLower().Split(' ');

            //afchecken of karakters alfabetisch zijn of niet
            //met Char-properties Char.IsLetter(chars[0].ToCharArray()[0])
            //eventueel omzetten naar char-array --> char[] karakters = Array.ConvertAll(chars, Convert.ToChar);
            //met ascii tabel https://www.asciitable.com/
            //met "azertyuiopqsdfghjklmwxcvbn".Contains...
            //opties genoeg!

            if (!"azertyuiopqsdfghjklmwxcvbn".Contains(chars[0]) ||
                !"azertyuiopqsdfghjklmwxcvbn".Contains(chars[1]))
            {
                Console.WriteLine("crazy input");
                return; //we stoppen uitvoering!!!
            }

            Regex regex = new Regex(@"\b" + chars[0] + @"\w*" + chars[1] + @"\b");
            //andere optie om de regex op te bouwen!!
            //Regex regex = new Regex($@"\b{chars[0]}\w*{chars[1]}\b");
            MatchCollection matches = regex.Matches(text);

            string[] words = new string[matches.Count];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = matches[i].Value;
            }

            Array.Sort(words);
            string word="";

            for (int i = 0; i < words.Length; i++)
            {
                if (word != words[i])
                {
                    Console.Write(words[i] + " ");
                    word = words[i];
                }
                
            }

        }
    }
}
