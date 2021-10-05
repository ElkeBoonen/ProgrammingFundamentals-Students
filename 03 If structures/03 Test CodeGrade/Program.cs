using System;

namespace _03_Test_CodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int jaar;
            bool gelukt = Int32.TryParse(input, out jaar);

            if (!gelukt)
            {
                Console.WriteLine("crazy input");
                return;
            }

            bool schrikkeljaar = false;

            if (jaar % 4 == 0)
            {
                if (jaar % 100 == 0)
                {
                    if (jaar % 400 == 0)
                    {
                        schrikkeljaar = true;
                    }
                    else
                    {
                        schrikkeljaar = false;
                    }
                }
                else
                {
                    schrikkeljaar = true;
                }
            }
            else 
            {
                schrikkeljaar = false;
            }

            Console.WriteLine(schrikkeljaar);
            
        }
    }
}
