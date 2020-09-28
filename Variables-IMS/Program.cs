using System;

namespace Variables_IMS
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b;     //declaratie
            b = 200;    //initialisatie
            //b = 300; je hebt meer dan één byte nodig voor 300! COMPUTER TOOLKIT

            int getal1 = 20;
            int getal2 = 3;

            char letter, cijfer, spatie;
            letter = 'a';
            cijfer = '4';
            spatie = ' ';

            string tekst = "dit is tekst";
            string tekstMetEenKarakter = "a";

            double d = 3.00000001;

            Console.WriteLine(d);
            d = d + 1; //++
            Console.WriteLine(d);
            d++;
            Console.WriteLine(d);
            d = d - 1; //--
            Console.WriteLine(d);
            d--;
            Console.WriteLine(d);

            //postfix & prefix -- ++
            Console.WriteLine("POSTFIX & PREFIX");
            Console.WriteLine(d++); //post - berekening wordt erna uitgevoerd
            Console.WriteLine(d--);
            Console.WriteLine(++d); //pre - berekening wordt ervoor uitgevoerd
            Console.WriteLine(--d);

            Console.WriteLine("OPERATOREN");
            Console.WriteLine("+");
            Console.WriteLine(getal1 + getal2);
            Console.WriteLine(getal1 + d);
            Console.WriteLine("-");
            Console.WriteLine(getal1 - getal2);
            Console.WriteLine(getal1 - d);
            Console.WriteLine("*");
            Console.WriteLine(getal1 * getal2);
            Console.WriteLine(getal1 * d);
            Console.WriteLine("/");
            Console.WriteLine(getal1 / getal2);
            Console.WriteLine(getal1 / 3.0);
            Console.WriteLine(Math.Round(getal1 / 3.0, 0));
            Console.WriteLine(getal1 / d);

            Console.WriteLine("%");
            int quotient = getal1 / getal2;
            int rest = getal1 % getal2;
            Console.WriteLine(quotient);
            Console.WriteLine(rest);

            Console.WriteLine(5 % 2); //1
            Console.WriteLine(4 % 2); //0

            Console.WriteLine("+ IN ANDERE CONTEXT");
            Console.WriteLine(20 + 2);
            Console.WriteLine(20 + "2");
            Console.WriteLine(20 + '2'); //70 ascii waarde '2' = 50

            //in commentaar zetten, 1 regel is met //, meerdere met /*¨*/
            /*Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Hallo " + naam);

            Console.Write("Geef je leeftijd: ");
            // int leeftijd = Convert.ToInt32(Console.ReadLine()); korter
            string antwoord  = Console.ReadLine();
            int leeftijd = Convert.ToInt32(antwoord);

            int geboortejaar = 2020 - leeftijd;
            geboortejaar = DateTime.Now.Year - leeftijd;

            //2 verschillende output-manieren, kies!
            Console.WriteLine("Dag {0} jij bent van {1}", naam, geboortejaar);
            Console.WriteLine("Dag " + naam + " jij bent van " + geboortejaar);
            */
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Geef een kleine letter in: ");
            char kleineLetter = Convert.ToChar(Console.ReadLine());
            int ascii = (int)kleineLetter; //cast 
            Console.WriteLine("Letter {0} heeft ascii {1}", kleineLetter, ascii);
            char hoofdletter = (char)(ascii - 32);
            Console.WriteLine("Hoofdletter van {0} is {1}", kleineLetter, hoofdletter);

            Console.WriteLine("Geef een karakter in: ");
            ascii = Console.Read();
            Console.WriteLine("Karakter {0} heeft ascii {1}", (char)ascii, ascii);

        }
    }
}
