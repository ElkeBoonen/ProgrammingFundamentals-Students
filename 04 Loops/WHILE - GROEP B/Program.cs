using System;

namespace WHILE___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef Y zolang je wilt verder gaan! ");
            string input = Console.ReadLine();

            while (input.ToUpper() == "Y") //(input=="y" || input == "Y") of (input.ToLower() == "y")
            { //zolang ik maar een y/Y ingeef blijf ik lopen
                Console.Write("Geef Y zolang je wilt verder gaan! ");
                input = Console.ReadLine();
            }

            //1 2 4 8 16 32 64 128...
            //1 3 9 27 81 243 729...
            //1 4 16 64 256...
            //1 5 25 125 625...

            Console.Write("Geef een getal in: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("WHILE - EERST AFPRINTEN");
            int resultaat = getal;
            while (resultaat < 1000)
            {
                Console.Write(resultaat + " ");
                resultaat *= getal;
            }

            Console.WriteLine("\nWHILE - EERST NIEUWE BEREKENING");
            resultaat = getal;
            while (resultaat < 1000)
            {
                
                resultaat *= getal;
                Console.Write(resultaat + " ");
            }

            Console.WriteLine("\nWHILE - EERST NIEUWE BEREKENING MAAR PRINT ERBOVEN");
            resultaat = getal;
            Console.Write(resultaat + " ");
            while (resultaat < 1000)
            {

                resultaat *= getal;
                Console.Write(resultaat + " ");
            }

            Console.WriteLine("\nDO WHILE - EERST AFPRINTEN");
            resultaat = 1;
            do
            {
                Console.Write(resultaat + " ");
                resultaat *= getal;
            } while (resultaat < 1000);

            Console.WriteLine("\nDO WHILE - EERST NIEUWE BEREKENING");
            resultaat = 1;
            do
            {
                resultaat *= getal;
                Console.Write(resultaat + " ");
            } while (resultaat < 1000);

            Console.WriteLine("\nFOR OMZETTEN NAAR WHILE");
            //FOR loop omzetten naar WHILE
            int i = 0; //i initialiseren
            while (i <= 10) //conditie
            {
                Console.WriteLine($"{i} * {getal} = {i * getal}");
                i++; //stapgrootte van i
            }

        }
    }
}
