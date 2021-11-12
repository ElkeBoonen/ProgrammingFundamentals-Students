using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace VOWELS___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef iets in: ");
            string antwoord = Console.ReadLine().ToLower();

            for (int i = 0; i < antwoord.Length; i++)
            {
                //antwoord.ElementAt(i)
                //string = array van karakters
                if (antwoord[i] == 'a' || antwoord[i] == 'e' || antwoord[i] == 'y'
                    || antwoord[i] == 'u' || antwoord[i] == 'i' || antwoord[i] == 'o')
                {
                    Console.Write((i+1) + " ");
                }
            }
            Console.WriteLine();

            char[] karakters = antwoord.ToCharArray();
            for (int i = 0; i < karakters.Length; i++)
            {
                if ("aeyuio".Contains(karakters[i]))
                {
                    Console.Write((i + 1) + " ");
                }
            }
            Console.WriteLine();
            int counter = 1;
            foreach (char item in antwoord)
            {
                switch (item)
                {
                    case 'a':
                    case 'e':
                    case 'y':
                    case 'u':
                    case 'i':
                    case 'o': 
                        Console.Write(counter + " "); 
                        break;
                }
                counter++;
            }
            Console.WriteLine();
            //werken met regexen, 2 opties:
            //(a|e|y|u|i|o) of [aeyuio]
            Regex regex = new Regex(@"[aeyuio]");
            MatchCollection matches = regex.Matches(antwoord);
            foreach (Match item in matches)
            {
                //let er bij op om Match item ipv var item te gebruiken!!!!
                //we krijgen veel meer mogelijkheden met het juiste type!
                Console.Write(item.Value + " " + (item.Index+1) + " ");
            }


        }
    }
}
