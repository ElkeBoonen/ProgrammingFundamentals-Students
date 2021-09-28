using System;

namespace Variables___IMS_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabelen declareren & initialiseren
            //let op: komma-getallen zijn met een punt ;)
            //voor variabelen namen gebruik je camelCasing
            byte eenByte;
            eenByte = 100;
            short s = 6000;
            int i = 56000;
            long l = 78675434343;
            double d = 678.8989;
            Console.WriteLine($"numerieke variabelen: {eenByte} {s} {i} {l} {d}");

            //char(acters) zijn met '' strings met ""
            char c = 'a';
            c = '5';
            c = ' ';
            c = '$';
            string varTekst = "Dat zijn meer karakters!";
            varTekst = "a";
            Console.WriteLine($"tekst variabelen: {c} {varTekst}");

            //doorgeven van waarden
            //iets klein in iets groot steken kan altijd!
            //een geheel getal in een komma getal steken kan ook altijd!
            l = eenByte + i;
            d = i;
            Console.WriteLine($"integer waarde {i} - double waarde {d}");

            //unary operators
            i = 10;
            Console.WriteLine(i);
            i++; //++i kan ook ++ voor variabele doen
            Console.WriteLine(i);
            --i; //i-- kan ook -- na variabele doen
            Console.WriteLine(i);

            //verschil tussen pre en postfix operatoren
            Console.WriteLine("");
            Console.WriteLine(i);
            Console.WriteLine("i++ = " + i++);
            Console.WriteLine("++i = " + ++i);

            //binaire operatoren
            Console.WriteLine("\n7 + 2 = " + (7+2)); //\n maakt lege lijn!
            Console.WriteLine($"7 - 2 = {7-2}");
            Console.WriteLine("7 * 2 = " + (7 * 2));
            Console.WriteLine("7 / 2 = " + (7 / 2));
            Console.WriteLine("7 % 2 = " + (7 % 2)); //modulo = rest na deling! 7/2 = 3 -> 7 - (3*2) = 1
            Console.WriteLine("7.0 / 2 = " + (7.0 / 2));

            //shorthand operatoren
            i = 10;
            Console.WriteLine("\n" + i);
            i += 10; //i = i + 10
            Console.WriteLine(i);
            i *= 2; // i = i * 2
            Console.WriteLine(i);
            i -= 5; // i = i -5
            Console.WriteLine(i);
            i /= 3; // i = i / 3
            Console.WriteLine(i);
            i %= 3; // i = i % 3
            Console.WriteLine(i);

            //string operator
            Console.WriteLine(5 + 5);
            Console.WriteLine("5" + 5);
            Console.WriteLine('5' + 5);

            //in en uitvoer via read, readline, write en writeline
            Console.Write("Geef een naam in: ");
            string naam = Console.ReadLine();
            Console.WriteLine($"Hallo {naam}");

            
            //CASTEN & CONVERTEREN
            Console.WriteLine("Geef een double waarde in: ");
            string antwoord = Console.ReadLine();
            double decimaalGetal = Convert.ToDouble(antwoord);
            int geheelGetal = (int)decimaalGetal;
            Console.WriteLine($"decimaal = {decimaalGetal}  -  geheel = {geheelGetal}");

            Console.WriteLine("Geef een geheel getal in: ");
            geheelGetal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"geheel = {geheelGetal}");

            //impliciete conversie
            decimaalGetal = geheelGetal;
            Console.WriteLine(decimaalGetal.ToString()); //toString is eigenlijk niet nodig!
            Console.WriteLine(decimaalGetal);

            Console.WriteLine("Het huidige jaar is " + DateTime.Now.Year);

            //read niet gebruiken - zorgt altijd voor problemenbij volgende invoer ;))
            Console.Write("Geef een karakter in: ");
            int ascii = Console.Read();
            Console.WriteLine($"ASCII waarde van {(char)ascii} is {ascii}");

        }
    }
}
