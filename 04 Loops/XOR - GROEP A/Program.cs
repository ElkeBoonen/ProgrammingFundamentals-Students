using System;

namespace XOR___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A (0 of 1): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("B (0 of 1): ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                Console.WriteLine(0);
            }
            else Console.WriteLine(1);

            if ((A == 0 && B == 1) || (A == 1 && B == 0))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

            if (A > B || B > A)
            {
                Console.WriteLine(1);
            }
            else Console.WriteLine(0);

            if (A == 1 ^ B == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

            int C = A + B;
            if (C == 1)
            {
                Console.WriteLine(1);
            }
            else Console.WriteLine(0);


        }
    }
}
