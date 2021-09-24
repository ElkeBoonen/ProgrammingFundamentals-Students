using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");
            System.Console.WriteLine("BLABLABLA");
            System.Console.WriteLine("BLABLABLA!");

            string anderenaam = "Elke";
            Console.WriteLine(anderenaam);

            string name;
            name = "Elke";
            Console.WriteLine(name);
            Console.WriteLine(name);
            name = "Mies";
            Console.WriteLine(name);
            name = "Bob";
            Console.WriteLine(name);

            Console.Write("Geef je naam in: ");
            name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Hello {name}!");
            Console.WriteLine($"Hello {name}!"); //dollarteken!!!!!
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
