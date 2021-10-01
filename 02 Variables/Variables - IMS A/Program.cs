using System;

namespace Variables___IMS_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABELEN DECLAREREN */
            int getal;
            byte eenByte;
            double decimaal;
            char c;

            /* VARIABELEN INITIALISEREN */
            getal = -6745;
            // eenByte = getal; gaat nooit lukken
            eenByte = 10;
            getal = eenByte; //iets klein in iets groter steken lukt wel!

            decimaal = 89.67;
            // getal = decimaal; gaat niet lukken, want integer is geen decimaal getal!
            decimaal = getal; //iets zonder komma in iets met komma steken lukt wel!

            c = 'c';
            c = '6';
            c = '^';

            /* VARIABELEN DECLAREREN & INITIALISEREN */
            string tekst = "a"; // van zodra w dubbele quotes gebruiken, ook al is het maar één karakter, het is en blijft een string!
            tekst = "Dit is tekst";


            /* REKENKUNDIGE OPERATOREN */
            Console.WriteLine("REKENKUNDIGE OPERATOREN");
            Console.WriteLine(getal);
            getal++;
            Console.WriteLine(getal);
            --getal;
            Console.WriteLine(getal);

            /* VERSCHIL TUSSEN PRE- & POSTFIX*/
            Console.WriteLine("VERSCHIL TUSSEN PRE- & POSTFIX");
            Console.WriteLine(getal++); //10
            Console.WriteLine(++getal); //12
            Console.WriteLine(getal--); //12
            Console.WriteLine(--getal); //10

            Console.WriteLine("REKENKUNDIGE OPERATOREN");
            Console.WriteLine(10 + 3); //13
            Console.WriteLine(10 - 3); //7
            Console.WriteLine(10 * 3); //30
            Console.WriteLine(10 / 3); //3
            Console.WriteLine(10.0 / 3); //3.3333333333...
            Console.WriteLine(10 % 3); //1 = rest na deling!!! 10 - (3*3) = 1

            //REST NA DELING BEPALEN ZONDER MODULO! 
            //HAAKJES ZIJN BELANGRIJK!!!!
            Console.WriteLine(10 - (3 * (10 / 3)));

            //TOEKENNEN & REKENEN
            Console.WriteLine("TOEKENNINGSOPERATOREN");
            getal = 10; Console.WriteLine(getal);
            getal += 3; Console.WriteLine(getal); //getal = getal + 3
            getal -= 3; Console.WriteLine(getal); //getal = getal - 3
            getal *= 3; Console.WriteLine(getal); //getal = getal * 3
            getal /= 3; Console.WriteLine(getal); //getal = getal / 3
            getal %= 3; Console.WriteLine(getal); //getal = getal % 3

            //VERGELIJKINGSOPERATOREN
            Console.WriteLine(10 > 3); //True
            Console.WriteLine(10 < 3); //False
            Console.WriteLine(10 >= 3); //True
            Console.WriteLine(10 <= 3); //False
            Console.WriteLine(10 == 3); //gelijk aan => False
            Console.WriteLine(10 != 3); //niet gelijk aan => True

            //STRINGOPERATOR
            Console.WriteLine(5 + 5);   //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); //58 --> karakters worden bewaard met hun int-waarde! '5' heeft int-waarde van 53

            //INPUT & OUTPUT
            Console.Write("Geef eens wat tekst: ");
            tekst = Console.ReadLine();
            Console.WriteLine("Je tekst was '" + tekst + "'");
            Console.WriteLine($"Je tekst was '{tekst}'");
            Console.WriteLine("Je tekst was '{0}'",tekst);
            //we escapen " --> zetten er een \ voor, om " af te drukken op scherm
            Console.WriteLine("Je tekst was \"" + tekst + "\"");
            Console.WriteLine($"Je tekst was \"{tekst}\"");
            Console.WriteLine("Je tekst was \"{0}\"", tekst);

            Console.Write("Geef een karakter in: ");
            int charwaarde = Console.Read();
            Console.WriteLine($"Je karakter heeft als waarde {charwaarde}");
            Console.ReadLine();

            //CASTEN  --> OMZETTEN
            c = (char)charwaarde; //cast
            Console.WriteLine($"Je karakter {c} heeft als waarde {charwaarde}");
            
            //CONVERT --> OMZETTEN
            Console.Write("Geef een getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Je getal was {getal}");

            Console.Write("Geef een decimaal getal in: ");
            decimaal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Je decimaal getal was {decimaal}");

            //CASTEN --> OMZETTEN TUSSEN TYPES
            getal = (int)decimaal; //met cast past decimaal wel in geheel, decimaal gedeelte wordt afgekapt!
            Console.WriteLine($"Je decimaal getal als int is {getal}");
        }
    }
}
