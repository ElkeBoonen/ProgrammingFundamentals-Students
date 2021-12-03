using System;
using System.Linq;

namespace BLAD_STEEN_SCHAAR___GROEP_A
{
    class Program
    {
        static string[] spel = { "blad", "steen", "schaar" };
        static int scoreComputer = 0;
        static int scoreGebruiker = 0; 

        static string Computer()
        {
            Random rd = new Random();
            //Next --> inclusive lowerbound, exclusive upperbound!
            int index = rd.Next(0, spel.Length);
            return spel[index];
        }

        static void Score(string gebruiker, string computer)
        {
            if (gebruiker == computer) return;

            if ((gebruiker == "blad" && computer == "steen") ||
                (gebruiker == "schaar" && computer == "blad") ||
                (gebruiker == "steen" && computer == "schaar"))
            {
                scoreGebruiker++;
            }
            else
            {
                scoreComputer++;
            }
        
        }

        static void Main(string[] args)
        {
            Console.Write("blad, steen of schaar? ");
            string gebruiker = Console.ReadLine();

            while (spel.Contains(gebruiker)) //gebruiker=="blad" || gebruiker=="steen" || gebruiker=="schaar"
            {
                string computer = Computer();
                Score(gebruiker, computer);
                Console.WriteLine($"Gebruiker: {scoreGebruiker} - Computer: {scoreComputer}");

                Console.Write("blad, steen of schaar? ");
                gebruiker = Console.ReadLine();

            }
        }
    }
}
