using System;

namespace Loops_IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL + C gebruiken om oneindige lus af te breken!!!!!

            Console.Write("x? ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nmaaltafels van 0 tem 10");
            for (int i = 0; i <=10; i++) //< 11
            {
                int result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
                //Console.WriteLine(i + " * " + x + " = " + result);
            }

            Console.WriteLine("\n\nmaaltafels van 10 tem 0");
            for (int i = 10; i >= 0; i--) // i met 1 verminderen
            {
                int result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
            }

            Console.WriteLine("\n\nmaaltafels van 0 tem 10 - enkel even nummers");
            //springen per 2 --> 0 2 4 6 8 10
            for (int i = 0; i <= 10; i=i+2) // i += 2
            {
                int result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
                //i++ mag dit niet doen = 'gevaarlijke' code ;) enkel i veranderen in definitie
            }


            Console.WriteLine("\n\nalle getallen tussen 0 en 100, deelbaar door 3");
            for (int i = 0; i <= 100; i++) 
            {
                if (i % 3 == 0) Console.Write(i + " ");
                /* andere versie --> uitgebreid met { }
                    if (i % 3 == 0) 
                    {
                        Console.Write(i + " ");    
                    }   */
            }

            Console.WriteLine("\n\nalle getallen tussen 0 en 100, deelbaar door 3 - zonder modulo");
            for (int i = 0; i <= 100; i+=3) Console.Write(i + " " );
            /* andere versie --> uitgebreid met { }
            for (int i = 0; i <= 10; i += 3)
            {
                Console.Write(i + " ");
            }*/

            Console.WriteLine("\n\ntabel van 4 op 6");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}{1} ", i, j);
                }

                Console.WriteLine();
            }


            Console.WriteLine("\n\ntabel van 4 op 6 met sterretjes");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\ndriehoek van sterren!");
            //*
            //**
            //***
            //****
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\ndriehoek van sterren - omgekeerd!");
            //****
            //***
            //**
            //*
            for (int i = 4; i >=0 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\ndriehoek van sterren - omgekeerd MET SPATIES!");
            //****
            // ***
            //  **
            //   *
            for (int i = 4; i >= 0; i--)
            {
                int spaties = 4 - i;

                for (int j = 0; j < spaties; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            
            Console.Write("VERDER? (ja om verder te gaan): ");
            string antwoord = Console.ReadLine(); //start

            while (antwoord == "ja") //eindvoorwaarde
            {
                Console.Write("VERDER? (ja om verder te gaan): ");
                antwoord = Console.ReadLine(); //variabele die meespeelt in eindvoorwaarde : veranderen in lus!!!
            }

            Console.Write("VERDER? (nee om te stoppen): ");
            antwoord = Console.ReadLine();

            while (antwoord != "nee")
            {
                Console.Write("VERDER? (nee om te stoppen): ");
                antwoord = Console.ReadLine(); //variabele die meespeelt in eindvoorwaarde : veranderen in lus!!!
            }
            
            //x is reeds bovenaan gedefineerd!
            Console.WriteLine("\n\nExponentieel! starten op 1 - print voor bewerking");
            x = 10;
            int exp = 1; //start
            while (exp < 100000) //voorwaarde
            {
                Console.Write(exp + " ");
                exp = exp * x; //result *= x; verkorte schrijfwijze //berekening, aanpassen van variabele uit voorwaarde
            }
            Console.WriteLine("\nresultaat na while is " + exp);

            Console.WriteLine("\n\nExponentieel! starten op 1 - print na bewerking");
            exp = 1;
            while (exp < 100000)
            {
                exp = exp * x; //result *= x; verkorte schrijfwijze
                Console.Write(exp + " ");
            }
            Console.WriteLine("\nresultaat na while is " + exp);

            Console.WriteLine("\n\nExponentieel! starten op x maar lopen tot <= 100000 - print voor bewerking");
            exp = x;
            while (exp <=100000)
            {
                Console.Write(exp + " ");
                exp = exp * x; //result *= x; verkorte schrijfwijze
            }
            Console.WriteLine("\nresultaat na while is " + exp);

            //zorgen dat het bulletproof is
            Console.WriteLine("\n\nExponentieel! zorgen dat -1, 0 en 1 niet meer meedoen!");
            x = -1;
            exp = x;
            while (exp <= 100000)
            {
                Console.Write(exp + " ");
                if ((x == 0) || (Math.Abs(x) == 1)) break; 
                exp = exp * x; //result *= x; verkorte schrijfwijze
            }
            Console.WriteLine("\nresultaat na while is " + exp);


            //while
            Console.WriteLine("\n\nWHILE");
            x = 100001;
            exp = x;
            while (exp <= 100000)
            {
                Console.Write(exp + " ");
                exp = exp * x; //result *= x; verkorte schrijfwijze
            }
           
            //while
            Console.WriteLine("\n\nZELFDE maar dan DO WHILE - wordt minstens 1 keer uitgevoerd");
            exp = x;
            do
            {
                Console.Write(exp + " ");
                exp = exp * x; //result *= x; verkorte schrijfwijze
            } while (exp <= 100000);

            x = 5;
            Console.WriteLine("\n\nFOR : maaltafels van 0 tem 10");
            for (int i = 0; i <= 10; i++) //< 11
            {
                int result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
            }

            Console.WriteLine("\n\nWHILE : maaltafels van 0 tem 10");
            int counter = 0; //start
            while (counter <= 10) //voorwaarde
            {
                int result = counter * x;
                Console.WriteLine("{0} * {1} = {2}", counter, x, result);
                counter++; //aanpassing van variabele die meespeelt in voorwaarde!
            }
        }
    }
}
