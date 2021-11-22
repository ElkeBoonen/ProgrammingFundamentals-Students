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
            string[] chars = Console.ReadLine().Split(' ');

            Regex regex = new Regex(@"[a-z]", RegexOptions.IgnoreCase);
            for (int i = 0; i < chars.Length; i++)
            {
                if (!regex.IsMatch(chars[i]))
                {
                    Console.WriteLine("crazy input");
                    return;
                }
            }

            /*foreach (var item in chars)
            {
                if (!"azertyuiopqsdfghjklmwxcvbn".Contains(item))
                {
                    Console.WriteLine("crazy input");
                    return;
                }
            }

            char[] karakters = Array.ConvertAll(chars, Convert.ToChar);
            foreach (char item in karakters)
            {
                if (!Char.IsLetter(item))
                {
                    Console.WriteLine("crazy input");
                    return;
                }
            }*/

            try //als er geen spatie is gezet!
            {
                regex = new Regex(@"\b"+ chars[0] + @"\w*" + chars[1] + @"\b");
                //regex = new Regex($@"\b{chars[0]}\w*{chars[1]}\b");
                //@ gebruiken we in regex om letterlijke strings te maken
                //$ gebruiken we voor waarden van variabelen bv in Console.WriteLine($"Eerste char {chars[0]}");

                MatchCollection matches = regex.Matches(text);

                string[] words = new string[matches.Count];

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = matches[i].Value;
                }

                Array.Sort(words);
                string word = "";

                for (int i = 0; i < words.Length; i++)
                {
                    if (word != words[i])
                    {
                        Console.Write(words[i] + " ");
                        word = words[i];
                    }

                }
            }
            catch {
                Console.WriteLine("crazy input");
            }

        }
    }
}
