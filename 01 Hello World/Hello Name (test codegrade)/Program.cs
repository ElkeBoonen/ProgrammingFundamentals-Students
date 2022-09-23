using System;

namespace Hello_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname;

            Console.WriteLine("Wat is uw voornaam?");
            firstname = Console.ReadLine();

            Console.WriteLine("Wat is uw achternaam?");
            lastname = Console.ReadLine();

            Console.WriteLine($"Hallo {firstname} {lastname}");
        }
    }
}
