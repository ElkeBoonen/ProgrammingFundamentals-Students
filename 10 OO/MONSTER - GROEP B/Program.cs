using System;

namespace MONSTER___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string methode = Console.ReadLine();
            Monster monster = new Monster();
            switch (methode)
            {
                case "1":
                    int jaar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(monster.NextLeapYear(jaar));

                    break;
                //en zo verder
                default:
                    Console.WriteLine("crazy input!");
                    break;
            }
        }
    }
}
