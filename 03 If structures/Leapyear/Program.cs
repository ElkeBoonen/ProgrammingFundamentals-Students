using System;

namespace Leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            string answer = Console.ReadLine();

            int year;
            if (!Int32.TryParse(answer, out year))
            {
                Console.WriteLine("Crazy input!");
                return; //stopt de uitvoering!
            }

            //makkelijkste manier om schrikkeljaar te vinden
            Console.WriteLine($"{year}: {DateTime.IsLeapYear(year)}");

            //maar nu is het aan jullie!
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Leap year!");
                    }
                    else
                    {
                        Console.WriteLine("Not a leap year!");
                    }
                }
                else 
                {
                    Console.WriteLine("Leap year!");
                }
            }
            else
            {
                Console.WriteLine("Not a leap year!");
            }


        }
    }
}
