using System;

namespace _01_Hello_Name__test_codegrade____DSPS
{
    internal class Program
    {
        /*
            Read the name and surname of a person and say 'Hello' to them.
            Input/Output
            input:
            Elke
            Boonen
            output:
            Hello Elke Boonen

         */

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();

            Console.WriteLine("Hello " + name + " " + surname);
            //Console.WriteLine($"Hello {name} {surname}");

        }
    }
}
