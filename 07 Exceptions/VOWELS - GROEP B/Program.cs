using System;
using System.Text.RegularExpressions;

namespace VOWELS___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord in: ");
            string woord = Console.ReadLine().ToLower();

            int index = 1;
            foreach (char c in woord)
            {
                if ("aeuioy".Contains(c))
                {
                    Console.Write(index + " ");
                } 
                index++;
            }

            Console.WriteLine();
            for (int i = 0; i < woord.Length; i++)
            {
                if (woord[i] == 'a' || woord[i] == 'e' || woord[i] == 'y'
                    || woord[i] == 'u' || woord[i] == 'i' || woord[i] == 'o')
                {
                    Console.Write((i+1) + " ");
                }
            }

            Console.WriteLine();
            Regex regex = new Regex(@"(a|e|y|u|i|o)");

            foreach (Match match in regex.Matches(woord))
            {
                //https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match?view=net-5.0
                //let op: itereren met juiste type anders krijg je alleen maar value te zien!!
                //var item in regex.Matches(woord)
                //item = match.Value
                Console.Write((match.Index+1) + " ");
            }

            Console.WriteLine();
            int j = 0;
            while (j < woord.Length)
            {
                switch (woord[j])
                {
                    case 'a':
                    case 'e':
                    case 'u':
                    case 'y':
                    case 'i':
                    case 'o': 
                        Console.Write((j + 1) + " ");
                        break;
                }
                j++;
            }


        }
    }
}
