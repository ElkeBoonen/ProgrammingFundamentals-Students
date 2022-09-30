using System;

namespace Herhaling___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //belangrijk om decimaal punt in te lezen!
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            //Console.WriteLine("Geef een getal in: ");
            //string antwoord = Console.ReadLine(); //-->antwoord wordt gegeven op nieuwe lijn

            Console.Write("Geef een getal in: ");
            string antwoord = Console.ReadLine();

            //check of een getal groter dan 10 en kleiner is dan 100
            int getal = Convert.ToInt32(antwoord);
            Console.WriteLine(10 < getal && getal < 100);
            Console.WriteLine((getal - 100) < 0); //getal kleiner dan 100
            Console.WriteLine((getal / 100) < 1); //getal kleiner dan 100
            Console.WriteLine((100 % getal) < 100); //getal kleiner dan 100
            //controleren of getal deelbaar is door 3
            Console.WriteLine((getal % 3) == 0);

            Console.Write("Geef nog een getal in: ");
            antwoord = Console.ReadLine();
            getal = Convert.ToInt32(antwoord); //expliciet converteren

            double decimaal = 3.5;
            decimaal += getal;              //impliciet converteren, compiler doet dat voor u
            Console.WriteLine(decimaal);    //impliciet converteren, compiler doet dat voor u

            getal = (int)decimaal;          //cast --> zelfde basis!
            Console.WriteLine(getal);       //impliciet converteren, compiler doet dat voor u

            antwoord = getal.ToString();    //expliciet converteren
            Console.WriteLine(antwoord);    //is helemaal ok!

            Console.Write("Geef een decimaal getal in: ");
            antwoord = Console.ReadLine();
            decimaal = Convert.ToDouble(antwoord); //expliciet converteren
            Console.WriteLine(decimaal);            //impliciet converteren, compiler doet dat voor u

            Console.Write("Geef nog een decimaal getal in: ");
            antwoord = Console.ReadLine();
            decimaal = Convert.ToDouble(antwoord); //expliciet converteren
            Console.WriteLine(decimaal);            //impliciet converteren, compiler doet dat voor u         

            Console.Write("Geef een karakter in: ");
            antwoord = Console.ReadLine();
            char c = Convert.ToChar(antwoord);
            //we kunnen wel casten tussen char en int omdat char onderliggend ook als int (ASCII waarde) wordt bewaard
            Console.WriteLine($"Het karakter {c} heeft ASCII-waarde {(int)c}");

            /*getal = 30;
            Console.WriteLine(10 < getal && getal < 100);
            Console.WriteLine((getal - 100) < 0); //getal kleiner dan 100
            Console.WriteLine((getal / 100) < 1); //getal kleiner dan 100
            Console.WriteLine((100 % getal) < 100); //getal kleiner dan 100
            //controleren of getal deelbaar is door 3
            Console.WriteLine((getal % 3) == 0);

            getal = 20;
            Console.WriteLine(10 < getal && getal < 100);
            Console.WriteLine((getal - 100) < 0); //getal kleiner dan 100
            Console.WriteLine((getal / 100) < 1); //getal kleiner dan 100
            Console.WriteLine((100 % getal) < 100); //getal kleiner dan 100
            //controleren of getal deelbaar is door 3
            Console.WriteLine((getal % 3) == 0);*/
        }
    }
}
