using System;

namespace _01_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.Write("Hallo");
            Console.Write("Nog eens hallo\n");
            Console.Write("\nNog \nnog \nnog eens hallo");
            Console.WriteLine("test");

            string naam;
            naam = "Elke";
            Console.WriteLine(naam);
            naam = "Jan";
            Console.WriteLine(naam);
            naam = "Bob";
            Console.WriteLine(naam);

            string stad = "Mechelen";
            Console.WriteLine("Ik woon in " + stad);
            Console.WriteLine("Ik woon in {stad}");
            Console.WriteLine($"Ik woon in {stad}");
            Console.WriteLine("{0} woont in {1}", naam, stad);

            string kleur;
            Console.Write("Geef je lievelingskleur in: ");
            kleur = Console.ReadLine();
            Console.WriteLine("Jij koos voor " + kleur);

            string dier;
            Console.WriteLine("Geef je lievelingsdier in: ");
            dier = Console.ReadLine();
            Console.WriteLine($"Jij koos voor {dier}");

        }
    }
}
