using System;

namespace XOR___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A (0 or 1):");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B (0 or 1):");
            int B = Convert.ToInt32(Console.ReadLine());

            if (((A == 0) && (B == 0)) || ((A == 1) && (B == 1)))
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }

            if ((A == 0) && (B == 0)) Console.WriteLine(0);
            else if ((A == 1) && (B == 1)) Console.WriteLine(0);
            else if ((A == 1) && (B == 0)) Console.WriteLine(1);
            else if ((A == 0) && (B == 1)) Console.WriteLine(1);

            if (A+B == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

            if (A == B) Console.WriteLine(0);
            else Console.WriteLine(1);
        }
    }
}
