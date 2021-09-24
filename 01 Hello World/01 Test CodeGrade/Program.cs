using System;

namespace _01_Test_CodeGrade
{
    class Program
    {
        /*Read the name and surname of a person and say 'Hello' to them!

        input
        Elke
        Boonen

        output
        Hello Elke Boonen!*/

        //dit is ook commentaar
        static void Main(string[] args)
        {
            string voornaam = Console.ReadLine();
            string famnaam = Console.ReadLine();

            Console.WriteLine($"Hello {voornaam} {famnaam}!");
        }
    }
}
