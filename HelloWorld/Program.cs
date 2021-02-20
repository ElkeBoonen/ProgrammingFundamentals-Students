using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Hello World!");
            Console.Write("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Elke!");

            string firstname = "Elke";
            string lastname;
            lastname = "Boone";
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);

            lastname = "Boonen";
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);

            Console.WriteLine(firstname + " " +  lastname);

            Console.WriteLine("Tell me your name");
            firstname = Console.ReadLine();
            Console.WriteLine("Your name is " + firstname);
        }
    }
}
