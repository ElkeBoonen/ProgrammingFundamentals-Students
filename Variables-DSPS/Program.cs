using System;

namespace Variables_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';

            int nr1, nr2; // declaring

            nr1 = 20; //initialising
            nr2 = 3;

            double d = 3.1;

            nr1 = 8;

            //++ --

            nr1 = nr1 + 1; //same thing
            Console.WriteLine(nr1);
            nr1++;
            Console.WriteLine(nr1);

            nr1 = nr1 - 1; //same thing
            nr1--;

            Console.WriteLine(nr1);
            Console.WriteLine(nr1++);//postfix operation after! 
            Console.WriteLine(nr1--);
            Console.WriteLine(++nr1);//prefix
            Console.WriteLine(--nr1);


            //nr1 = 8, nr2 = 3, d = 3.1
            Console.WriteLine("+");
            Console.WriteLine(nr1 + nr2);
            Console.WriteLine(nr1 + d);

            Console.WriteLine("-");
            Console.WriteLine(nr1 - nr2);
            Console.WriteLine(nr1 - d);

            Console.WriteLine("*");
            Console.WriteLine(nr1 * nr2);
            Console.WriteLine(nr1 * d);

            Console.WriteLine("/");
            Console.WriteLine(20 / 3);
            Console.WriteLine(Math.Round(20 / 3.0)); ;
            Console.WriteLine(20 / 3.0);

            Console.WriteLine("%");
            Console.WriteLine(20 % 3);

            Console.WriteLine(5 % 2); //odd
            Console.WriteLine(4 % 2); //odd


            int result = 20 / 3;
            
            int remainder = 20 % 3;
            remainder = 20 - (3 * result);

            Console.WriteLine("+");
            Console.WriteLine(20 + 2);
            Console.WriteLine(20 + "2");
            Console.WriteLine(20 + '2'); //http://www.asciitable.com/
            
            /*
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            string answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);
            int birthyear = 2020 - age;
            Console.WriteLine("Hello " + name + " birthyear: " + birthyear);
            birthyear = DateTime.Now.Year - age;
            Console.WriteLine("Hello {0} birthyear: {1}", name, birthyear);*/

            Console.Write("Character: ");
            char ch = Convert.ToChar(Console.ReadLine()); // convert in 1 step!
            int ascii = (int)ch;
            Console.WriteLine("Character " + ch + " with ascii value" + ascii);

            char capCH = (char)(ascii - 32);
            Console.WriteLine("Character {0} with ascii value {1}, capital {2}", ch, ascii, capCH);

            Console.Write("Character: ");
            ascii = Console.Read();
            Console.WriteLine("Ascii value " + ascii + " character" + (char)ascii);

        }
    }
}
