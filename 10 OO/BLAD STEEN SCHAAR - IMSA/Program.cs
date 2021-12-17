using System;

namespace BLAD_STEEN_SCHAAR___IMSA
{
    class Program
    {
        static int Translate(string input)
        {
            if (input.ToLower() == "rock") return 0;
            if (input.ToLower() == "paper") return 1;
            if (input.ToLower() == "scissors") return 2;
            return -1;
        }

        static void Main(string[] args)
        {
            RPS rps = new RPS();
            Console.Write("Rock, paper, scissors? ");
            string input = Console.ReadLine();

            while (Translate(input) != -1)
            {
                Hand user = (Hand)Translate(input);
                Hand computer = rps.TurnComputer();
                Console.WriteLine("Cmputer chose " + computer);
                rps.Score(computer, user);
                Console.WriteLine(rps.ToString());

                Console.Write("\nRock, paper, scissors? ");
                input = Console.ReadLine();
            }
        }
    }
}
