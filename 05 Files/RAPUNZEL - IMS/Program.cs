using System;
using System.IO; //altijd als je met files werkt System.IO importeren!!!

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



        }
    }
}
