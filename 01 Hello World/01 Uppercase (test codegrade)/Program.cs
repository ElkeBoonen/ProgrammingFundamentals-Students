using System;

namespace _01_Uppercase__test_codegrade_
{
    internal class Program
    {
        /*
         Read the name of a person and print the name in uppercase characters.

            Input/Output
            input:
            Elke
            output:
            HELLO ELKE
         
         */
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string upper = name.ToUpper();
            Console.WriteLine("HELLO " + upper);


            /*
                string name = Console.ReadLine().ToUpper();
                Console.WriteLine("HELLO " + name);

                string name = Console.ReadLine();
                Console.WriteLine("HELLO " + name.ToUpper());

                string name = Console.ReadLine();
                name = name.ToUpper();
                Console.WriteLine("HELLO " + name);

                string name = Console.ReadLine();
                name = name.ToUpper();
                Console.WriteLine($"HELLO {name}");
             
             
             */
        }
    }
}
