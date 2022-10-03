using System;
using System.Text;

namespace _03_Case__test_codegrade____DSPS
{
    class Program
    {

        //Check whether a character entered is uppercase or lowercase. In any other case you print 'crazy input'.

        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            int ascii = (int)c;

            if (ascii >= 62 && ascii <= 90)
            {
                Console.WriteLine("uppercase");
            }
            else if (ascii >= 97 && ascii <= 122)
            {
                Console.WriteLine("lowercase");
            }
            else {
                Console.WriteLine("crazy input");
            }

            if ("AZERTYUIOPQSDFGHJKLMWXCVBN".Contains(c))
            {
                Console.WriteLine("uppercase");
            }
            else if ("azertyuiopqsdfghjklmwxcvbn".Contains(c)) //("AZERTYUIOPQSDFGHJKLMWXCVBN".ToLower()
            {
                Console.WriteLine("lowercase");
            }
            else
            {
                Console.WriteLine("crazy input");
            }

            if (Char.IsUpper(c))
            {
                Console.WriteLine("uppercase");
            }
            else if (Char.IsLower(c))
            {
                Console.WriteLine("lowercase");
            }
            else {
                Console.WriteLine("lowercase");
            }

            //if (c == 'A' || c == 'B' || c == 'C' //etc)

        }
    }
}
