using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************************
             * writing to a file!!!!
             * ***********************/
            string filename = "file.txt";
            filename = @"C:\file.txt";
            filename = Path.Combine(@"C:\", "file.txt");

            //never use an absolute path!!! C: \Users\elkeb\OneDrive\Desktop
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename = Path.Combine(folder, "file.txt");

            StreamWriter output = File.CreateText(filename);
            output.WriteLine("1");
            output.WriteLine("2");
            output.WriteLine("3");
            output.Close();

            if (File.Exists(filename))
            {
                output = File.AppendText(filename);
                output.WriteLine("4");
                output.WriteLine("5");
                output.WriteLine("6");
                output.Close();
            }

            File.Delete(filename);


            /*************************
             * reading from a file!!!!
            *************************/
            Console.WriteLine("\n\n\nREAD TO END");
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            //Console.WriteLine(text);
            input.Close();
            /*
            Console.WriteLine("\n\n\nREAD LINE BY LINE");
            input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();
            while (line != null)
            {
                Console.WriteLine("LINE : " + line);
                line = input.ReadLine(); //read the next line!!!!
            }
            input.Close();

            Console.WriteLine("\n\n\nREAD CHAR BY CHAR");
            input = File.OpenText("Rapunzel.txt");
            char c = (char)input.Read();
            while (!input.EndOfStream)
            {
                Console.Write(c + " ");
                c = (char)input.Read(); //read the next character!!!!
            }
            input.Close();

            Console.WriteLine("\n\n\nREAD CHAR BY CHAR -- FOR");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text.ElementAt(i) + " ");
            }

            Console.WriteLine("\n\n\nREAD CHAR BY CHAR -- FOREACH");
            foreach (var item in text)
            {
                Console.Write(item + " ");
            }
            */

            Console.WriteLine("Length: " + text.Length);
            Console.WriteLine("First 10: " + text.Substring(0, 10));
            Console.WriteLine("Last 10: " + text.Substring(text.Length-10,10));
            Console.WriteLine("First occurrence: " + text.IndexOf("Rapunzel"));

            text = text.ToLower();
            Console.WriteLine("First occurrence: " + text.IndexOf("Rapunzel")); //-1 not found!!!
            Console.WriteLine("First occurrence with lowercase r: " + text.IndexOf("rapunzel"));
            Console.WriteLine("Last occurrence with lowercase r: " + text.LastIndexOf("rapunzel"));

            int count = 0;
            string word = "";
            foreach (char ch in text)
            {
                //switch case 'a', 'b'...
                if ((ch >= 97) && (ch <= 122))
                {
                    word += ch; //word = word + ch
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
            Console.WriteLine("# rapunzel: " + count);

            Regex rx = new Regex(@"RAPUNzel", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine("# rapunzel (regex): " + matches.Count);

            word = "";
            string abc = "azertyuiopqsdfghjklmwxcvbn";
            foreach (char ch in text)
            {
                if (abc.Contains(ch))
                {
                    word += ch; //word = word + ch
                }
                else
                {
                    if (word.Length == 9)
                    {
                        Console.WriteLine(word);
                    }
                    word = "";
                }
            }

            rx = new Regex(@"\b[a-z]{9}\b", RegexOptions.IgnoreCase);
            matches = rx.Matches(text);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }

        }
    }
}
