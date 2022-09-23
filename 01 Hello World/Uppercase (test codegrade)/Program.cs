using System;

namespace Uppercase__test_codegrade_
{
    /*
     Read the name of a person and print the name in uppercase characters.

    Input/Output
    input:
    Elke
    output:
    HELLO ELKE

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("HELLO " + name.ToUpper());

            //andere manieren
            //string name = Console.ReadLine().ToUpper();
            //Console.WriteLine("HELLO " + name);

            //string name = Console.ReadLine();
            //name = name.ToUpper()
            //Console.WriteLine("HELLO " + name);

            //string name = Console.ReadLine();
            //string upper = name.ToUpper()
            //Console.WriteLine("HELLO " + upper);

            //string name = Console.ReadLine();
            //Console.WriteLine($"HELLO {name}");
        }
    }
}
