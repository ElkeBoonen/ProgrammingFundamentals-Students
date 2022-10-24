using System;

namespace SOCCER___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] team = new string[3][];

            for (int i = 0; i < team.Length; i++)
            {
                //add every row
                Console.WriteLine($"Enter names (split by space) for row {i+1}");
                team[i] = Console.ReadLine().Split(' ');
                //split on space to get players out
            }

            //get formation by length of every row
            Console.WriteLine($"Formation {team[0].Length}-{team[1].Length}-{team[2].Length}");

            //messi ronaldo ibrahim
            //kevin lukaku hazard
            //neymar ramos mbappé benzema

            //print out every player
            foreach (var item in team) //loop every row
            {
                foreach (var player in item) //loop every element in the row
                {
                    Console.Write(player + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
