using System;

namespace TestCodeGrade
{
    class Program
    {
        /*
         Read the name and birth year of a person. Say hello and calculate his/her age!

            input
            Elke
            1980
            output
            Hello Elke, you are 40 years old.
             
             */

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine());

            int age = DateTime.Now.Year - year;
            Console.WriteLine("Hello {0}, you are {1} years old.", name, age);

        }
    }
}
