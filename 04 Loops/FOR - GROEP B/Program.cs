using System;

namespace FOR___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een getal in: ");
            int getal = 7; //Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) //<11 doet net hetzelfde!!
            {   //lus wordt 11 keer uitgevoerd
                int result = getal * i;
                Console.WriteLine($"{getal} * {i} = {result}");
            }

            for (int i = 1; i <= 10; i++) 
            {   //lus wordt 10 keer uitgevoerd, start op 1 eindigt op 10
                int result = getal * i;
                Console.WriteLine($"{getal} * {i} = {result}");
            }

            for (int i = 1; i <= 10; i+=3) 
            {   //lus wordt 4 keer uitgevoerd, stap met 3 --> 1 4 7 10
                int result = getal * i;
                Console.WriteLine($"{getal} * {i} = {result}");
            }

            for (int i = 1; i <= 10; i *= 2)
            {   //lus wordt 4 keer uitgevoerd, stap met *2 --> 1 2 4 8, essentieel om te starten op 1
                //anders oneindige lus
                int result = getal * i;
                Console.WriteLine($"{getal} * {i} = {result}");
            }

            for (int i = 10; i <= 0; i--) 
            {   //lus wordt nooit uitgevoerd!!!
                int result = getal * i;
                Console.WriteLine($"{getal} * {i} = {result}");
            }

            for (int i = 10; i > 0; i--)
            {   //lus wordt nooit uitgevoerd!!!
                int result = getal * i;
                Console.WriteLine($"{getal} * {i} = {result}");
            }

            Console.WriteLine("\nGENESTE LUSSEN");

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i * j + "\t"); //Console.WriteLine($"{i * j} ");
                }
                Console.WriteLine();           
            }

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /*
             
             *
             **
             ***
             ****
             *****

             */

            Console.Write("Geef het aantal sterretjes in: ");
            int aantal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < aantal; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

            /*
             
             *****
             ****
             ***
             **
             *

             */

            Console.WriteLine();
            for (int i = 0; i < aantal; i++)
            {
                for (int j = aantal; j > i; j--)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //alternatieve oplossing
            for (int i = aantal; i > 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }


        }
    }
}
