using System;

namespace Case___test_coedegrade____IMS
{
    internal class Program
    {
        //Check whether a character entered is uppercase or lowercase.
        //In any other case you print 'crazy input'.
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            char c;

            if (!Char.TryParse(answer, out c))
            {
                Console.WriteLine("crazy input");
                return;
            }

            //versie 1 om te checken of iets uppercase is
            if (answer.ToUpper() == c.ToString()) { }
            //versie 2 - Char library
            if (Char.IsUpper(c)) { }
            //versie 3
            if ((int)c >= 65 && (int)c <= 90) { }
            //versie 4
            if ("AZERTYUIOPQSDFGHJKLMWXCVBN".Contains(c)) { }
        }
    }
}
