using System;

namespace Feedback_09_12
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = Console.ReadLine();
            try
            {
                int nr = Convert.ToInt32(answer);
                int som = 0;

                bool plus = true;

                Console.Write("som = ");

                for (int i = 1; i < nr; i += 3)
                {
                    if (plus)
                    {
                        som += i;
                        Console.Write(" + " + i);
                    }
                    else
                    {
                        som -= i;
                        Console.Write(" - " + i);
                    }
                    plus = !plus;

                }

                Console.Write(" = " + som);
            }
            catch {
                Console.WriteLine("crazy input");
            }
        }
    }
}
