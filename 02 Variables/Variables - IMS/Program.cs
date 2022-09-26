using System;
using System.Linq;

namespace Variables___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 5;
            byte numberByte = 200;

            //numberByte = 300; --> geeft foutmelding, byte kan maar tem 255

            double numberDouble = 1.67889009876;
            //float numberFloat = numberDouble; --> gaat niet lukken, float heeft minder cijfers na komma

            string name = "Elke";
            char c = 'e';

            Console.WriteLine(numberInt);
            Console.WriteLine(numberByte);
            Console.WriteLine(numberDouble);
            Console.WriteLine(name);
            Console.WriteLine(c);

            int width, height;  //declaratie groeperen van variabelen per type
            width = 5;          //initialisatie
            height = 8;

            height = 4;         //variabelen kunnen wijzigen van waarde!

            numberInt++;
            Console.WriteLine(numberInt);
            --numberInt;
            Console.WriteLine(numberInt);

            Console.WriteLine("--> POST & PREFIX ++ en --");
            Console.WriteLine(numberInt++);
            Console.WriteLine(++numberInt);
            Console.WriteLine(numberInt--);
            Console.WriteLine(--numberInt);

            Console.WriteLine("--> REKENKUNDIGE OPERATOREN");
            int x, y;
            x = numberInt;
            y = numberByte; //byte is kleiner dan int, dus past er perfect in!
            Console.WriteLine($"{x}+{y} = {x + y}"); //tussen { } kan ook een berekening komen!
            Console.WriteLine($"{x}-{y} = {x - y}");
            Console.WriteLine($"{x}*{y} = {x * y}");
            Console.WriteLine($"{x}/{y} = {x / y} --> integer deling = kapt decimaal gedeelte af");
            Console.WriteLine($"{5.0}/{y} = {5.0 / y} --> gewone deling");

            Console.WriteLine("--> MODULO");    //modulo, rest na deling
            Console.WriteLine($"{10}%{9} = {10 % 9}"); // 10/9 = 1, overschot = 1 = rest
            Console.WriteLine($"{10}%{8} = {10 % 8}"); // 10/8 = 1, rest = 2
            Console.WriteLine($"{10}%{7} = {10 % 7}"); // 10/7 = 1, rest = 3
            Console.WriteLine($"{10}%{6} = {10 % 6}"); // 10/6 = 1, rest = 4
            Console.WriteLine($"{10}%{5} = {10 % 5}"); // 10/5 = 2, rest = 0 -- PERFECT DEELBAAR
            Console.WriteLine($"{10}%{4} = {10 % 4}"); // 10/4 = 2, rest = 2 
            Console.WriteLine($"{10}%{3} = {10 % 3}"); // 10/3 = 3, rest = 1 
            Console.WriteLine($"{10}%{2} = {10 % 2}"); // 10/2 = 5, rest = 0 -- PERFECT DEELBAAR
            Console.WriteLine($"{10}%{1} = {10 % 1}"); // 10/1 = 10, rest = 0 -- PERFECT DEELBAAR

            Console.WriteLine($"--> modulo zonder modulo ;)");
            //10%3  --> 10/3 = 3, rest = 1 
            int resultaat = 10 / 3;
            int rest = 10 - (resultaat * 3);
            Console.WriteLine($"{10}%{3} = {rest}");

            Console.WriteLine("--> TOEKENNINGSOPERATOREN");
            x = 10;
            Console.WriteLine(x);
            x += 10; // x = x + 10
            Console.WriteLine("+= 10 --> " + x);
            x -= 7;
            Console.WriteLine("-= 7 --> " + x);
            x *= 7;
            Console.WriteLine("*= 7 --> " + x);
            x /= 5;
            Console.WriteLine("/= 5 --> " + x);
            x %= 3;
            Console.WriteLine("%= 3 --> " + x);

            Console.WriteLine("--> VERGELIJKINGSOPERATOREN");
            x = 5;
            y = 7;

            Console.WriteLine($"x={x} y={y}");
            Console.WriteLine($"x < y : {x < y}");
            Console.WriteLine($"x <= y : {x <= y}");
            Console.WriteLine($"x > y : {x > y}");
            Console.WriteLine($"x >= y : {x >= y}");
            Console.WriteLine($"x == y : {x == y}");
            Console.WriteLine($"x != y : {x != y}");
            Console.WriteLine(x != y);

            Console.WriteLine("--> TEKST 'OPTELLEN' = CONCATENEREN");
            name += " Boonen";      //nieuw deel wordt erachter geplakt!
            Console.WriteLine(name);
            name = "Elke";
            name = "Boonen " + name; //wil je iets dat ervoor wordt geplakt, gebruik dan geen +=
            Console.WriteLine(name);

            Console.WriteLine("--> KARAKTERS");
            Console.WriteLine("name = " + name);
            char eersteLetter = name.ElementAt(0);
            Console.WriteLine("Eerste karakter van naam: " + eersteLetter);
            eersteLetter = name[0];     //karakter op de eerste plaats, we starten van 0
            Console.WriteLine("Eerste karakter van naam: " + eersteLetter);

            Console.WriteLine("--> RARITEITEN");
            Console.WriteLine(5 + 5);
            Console.WriteLine("5" + 5);
            Console.WriteLine(5 + "5");
            Console.WriteLine('5' + 5);
            Console.WriteLine(5 + '5');





        }
    }
}
