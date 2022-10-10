using System;

namespace FOR___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal in: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //idiote manier ;) 
            Console.WriteLine($"{x} * 1 = {x * 1}");
            Console.WriteLine($"{x} * 2 = {x * 2}");
            Console.WriteLine($"{x} * 3 = {x * 3}");
            //...

            Console.WriteLine("FOR - van 0 tem 10");
            for (int i = 0; i <= 10; i++) //i < 11 --> als je 10 mee wilt pakken!
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
                //Console.WriteLine(x + " * " + i + " = " + result);
            }

            Console.WriteLine("FOR - van 1 tem 10");
            for (int i = 1; i <= 10; i++)  //i = startwaarde pas aan!
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
            }

            Console.WriteLine("FOR - van 1 tem 10 in sprongen van 2");
            for (int i = 1; i <= 10; i+=2)  //pas i++ aan
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
            }

            Console.WriteLine("FOR - van 0 tem 10 in even getallen van 2");
            for (int i = 0; i <= 10; i += 2)  //zet je i terug op 0
            {
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
            }

            Console.WriteLine("FOR - 1, 2, 4, 8, 16 enz..");
            for (int i = 1; i <= 20; i *= 2)  //GOED OPLETTEN DAT JE START OP 1
            {                                 //ANDERS ONEINDIGE LUS!!!
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
            }

            Console.WriteLine("FOR - 10 naar 0 ");
            //for (int i = 10; i <= 0; i--) --> niet vergeten voorwaarde aan te passen, anders krijg je niets te zien
            //for (int i = 10; i >= 0; i++) --> iterator aanpassen, anders 'oneindige lus', blijft lopen tot result te groot wordt voor een integer
                for (int i = 10; i >= 0; i--)  
            {                                 
                int result = i * x;
                Console.WriteLine($"{x} * {i} = {result}");
            }

            //veelvouden van 3 - versie 1
            Console.WriteLine("VEELVOUDEN VAN 3 - VERSIE 1");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                } 
            }
            //veelvouden van 3 - versie 1
            Console.WriteLine("\nVEELVOUDEN VAN 3 - VERSIE 2");
            for (int i = 0; i <= 100; i+=3)
            {
                Console.Write(i + " ");
            }

            //machten van 3
            Console.WriteLine("\nMACHTEN VAN 3");
            for (int i = 1; i <= 100; i *= 3) //als je * doet, i op 1 zetten
            {
                Console.Write(i + " ");
            }

            //alle even getallen tussen x & y

            Console.Write("\nGeef een getal in: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Alle even getallen tussen {x} en {y}");
            //als y kleiner is dan x -> geen output! 
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nNESTEN VAN LUSSEN");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nNESTEN VAN LUSSEN");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nNESTEN VAN LUSSEN");
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nNESTEN VAN LUSSEN");
            /*
             1
             2 2
             3 3 3
             4 4 4 4
             5 5 5 5 5
             ...
             */
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}