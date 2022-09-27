using System;

namespace Age___DSPS
{
    internal class Program
    {
        //calculate the age of a person

        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth: ");
            //string answer = Console.ReadLine();
            //int year = Convert.ToInt32(answer);
            int year = Convert.ToInt32(Console.ReadLine());

            int currentYear = DateTime.Now.Year;

            int age = currentYear - year;
            Console.WriteLine($"You are {age} years old");

            int days = age * 365;
            Console.WriteLine($"You are already {days} days on this planet!");

            int minutes = days * 24 * 60;
            Console.WriteLine($"You are already {minutes} minutes on this planet!");

            //Console.ReadLine(); --> only if you have a Mac, to stop execution

        }
    }
}
