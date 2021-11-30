using System;

namespace BLAD_STEEN_SCHAAR___GROEP_B
{
    class Program
    {
        static int scoreComputer=0;
        static int scoreGebruiker = 0;


        static string Computer()
        {
            string[] hand = { "blad", "steen", "schaar" };
            Random rd = new Random();
            int index = rd.Next(0, 3);
            return hand[index];
        }

        static void Score(string computer, string gebruiker)
        {
            if (computer == gebruiker) return;

            if ((computer == "blad" && gebruiker == "steen") ||
                (computer == "schaar" && gebruiker == "blad") ||
                (computer == "steen" && gebruiker == "schaar"))
            {
                scoreComputer++;
            }
            else scoreGebruiker++;
        }


        static void Main(string[] args)
        {
            Console.Write("blad, steen, schaar? ");
            string hand = Console.ReadLine();

            while (hand == "blad" || hand == "steen" || hand == "schaar")
            {
                string computer = Computer();
                Console.WriteLine($"Computer koos voor {computer}");
                Score(computer, hand);
                Console.WriteLine($"{scoreGebruiker} - {scoreComputer} (computer)");

                //opnieuw vraag stellen!!
                Console.Write("blad, steen, schaar? ");
                hand = Console.ReadLine();
            }

        }
    }
}
