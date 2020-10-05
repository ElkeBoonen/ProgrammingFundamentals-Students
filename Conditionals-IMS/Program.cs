using System;

namespace Conditionals_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Paswoord: ");
            string paswoord = Console.ReadLine(); //console is altijd een string!

            //variatie 1
            if (paswoord == "test123")
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            else if (paswoord == "123test")
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            else
            {
                Console.WriteLine("OEPSIE! Verkeerd paswoord!");
            }


            //waarom else if wordt gebruikt!!!!
            if (paswoord == "test123")
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            if (paswoord == "123test") //je start een nieuwe if-structuur en dat is niet de bedoeling!!!!
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            else
            {
                Console.WriteLine("OEPSIE! Verkeerd paswoord! - geen else if gebruikt!");
            }

            //variatie 2
            if (paswoord == "test123")
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            else
            {
                if (paswoord == "123test")
                {
                    Console.WriteLine("HOERA! Je bent binnen!");
                }
                else
                {
                    Console.WriteLine("OEPSIE! Verkeerd paswoord!");
                }
            }

            //variatie 3 - combineren van voorwaarden
            if ((paswoord == "test123") || (paswoord == "123test"))
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            else
            {
                Console.WriteLine("OEPSIE! Verkeerd paswoord!");
            }

            //variatie 4 - omgekeerd van 3
            if ((paswoord != "test123") && (paswoord != "123test"))
            {
                Console.WriteLine("OEPSIE! Verkeerd paswoord!");
            }
            else
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }


            //variatie 5 - met een boolean
            bool voorwaarde = (paswoord == "test123") || (paswoord == "123test");

            if (voorwaarde) //voorwaarde == true
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            else
            {
                Console.WriteLine("OEPSIE! Verkeerd paswoord!");
            }

            //variatie 6 - NOT boolean voorwaarde
            if (!voorwaarde) // !TRUE == FALSE ==> !FALSE = TRUE
            {
                Console.WriteLine("OEPSIE! Verkeerd paswoord!");
            }
            else
            {
                Console.WriteLine("HOERA! Je bent binnen!");
            }
            

            Console.Write("Leeftijd: ");
            string antwoord = Console.ReadLine(); //altijd een string!!!
            int leeftijd;

            bool gelukt = Int32.TryParse(antwoord, out leeftijd); //leeftijd wordt 0 bij niet kunnen parsen

            if (gelukt)
            {
                if (leeftijd >= 18)
                {
                    Console.WriteLine("Volwassen!");
                }
                else
                {
                    Console.WriteLine("Niet volwassen!");
                }
            }
            else
            {
                Console.WriteLine("Verkeerde invoer!!!!");
                return; //als verkeerde invoer is: stop er helemaal mee!
            }


            if (leeftijd == 0) //leeftijd < 1
            {
                Console.WriteLine("baby");
            }
            else if (leeftijd < 3)  //leeftijd <= 2 of deze ((leeftijd >= 1) && (leeftijd <= 2))
            {
                Console.WriteLine("peuter");
            }
            else if (leeftijd < 6)
            {
                Console.WriteLine("kleuter");
            }
            else if (leeftijd < 10)
            {
                Console.WriteLine("kind");
            }
            else if (leeftijd < 14)
            {
                Console.WriteLine("tiener");
            }
            else if (leeftijd < 16)
            {
                Console.WriteLine("puber");
            }
            else if (leeftijd < 18)
            {
                Console.WriteLine("jong volwassene");
            }
            else
            {
                Console.WriteLine("volwassene");

            }

            //variatie 2
            if (leeftijd >= 18)
            {
                Console.WriteLine("volwassene");
            }
            else if (leeftijd > 15) // leeftijd >= 16 
            {
                Console.WriteLine("jong volwassene");
            }
            else if (leeftijd > 13)
            {
                Console.WriteLine("puber");
            }
            else if (leeftijd > 9)
            {
                Console.WriteLine("tiener");
            }
            else if (leeftijd > 5)
            {
                Console.WriteLine("kind");
            }
            else if (leeftijd > 2)
            {
                Console.WriteLine("kleuter");
            }
            else if (leeftijd > 0)
            {
                Console.WriteLine("peuter");
            }
            else
            {
                Console.WriteLine("baby");
            }

            switch (leeftijd)
            {
                case 0: Console.WriteLine("baby"); break; //break stopt met switch
                case 1:
                case 2: Console.WriteLine("peuter"); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("kleuter"); break;
                case 6:
                case 7:
                case 8:
                case 9: Console.WriteLine("kind"); break;
                case 10:
                case 11:
                case 12:
                case 13: Console.WriteLine("tiener"); break;
                case 14:
                case 15: Console.WriteLine("puber"); break;
                case 16:
                case 17: Console.WriteLine("jong volwassene"); break;
                default: Console.WriteLine("volwassene"); break;
            }

        }
    }
}
