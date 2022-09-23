using System;

namespace Hello_Again___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            firstname = "Elke";
            firstname = "Tuur";

            string colour = "green";

            //string age = 42; --> this is not correct! string = text, not a number!
            string age = "42";

            Console.WriteLine("Enter your first name");
            firstname = Console.ReadLine();

            Console.WriteLine("Enter your favourite colour");
            colour = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = Console.ReadLine();

            /*
                different ways of printing & concatenating text
                use $ before "" and { } for the variable names
             */

            Console.WriteLine("Hello " + firstname);
            Console.WriteLine("Hello firstname");
            Console.WriteLine($"Hello {firstname}");

            Console.WriteLine(firstname + " is " + age + " years old");

        }
    }
}
