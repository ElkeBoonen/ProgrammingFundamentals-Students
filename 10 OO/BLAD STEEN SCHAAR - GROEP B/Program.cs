using System;

namespace BLAD_STEEN_SCHAAR___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {

            BSS bss = new BSS();

            Console.Write("blad = 0, steen = 1, schaar = 2? ");
            int hand = Convert.ToInt32(Console.ReadLine());

            while (hand == 0 || hand == 1 || hand == 2)
            {
                Hand computer = bss.Computer();
                Console.WriteLine($"Computer koos voor {computer}");
                bss.Score(computer, (Hand)hand);
                Console.WriteLine(bss);

                //opnieuw vraag stellen!!
                Console.Write("blad = 0, steen = 1, schaar = 2? ");
                hand = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
