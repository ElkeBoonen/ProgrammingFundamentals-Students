using System;

namespace Months___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a month");
            string answer = Console.ReadLine();
            int month;

            //try parse input --> check if input is valid!!!
            if (!Int32.TryParse(answer, out month))
            {
                Console.WriteLine("crazy input!");
                return;
            }

            //check if current year is leap year, store result in boolean
            //https://www.softwareideas.net/a/1642/leap-year-check-flowchart-
            int year = DateTime.Now.Year;
            bool leapyear = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        leapyear = true;
                    }
                }
                else
                {
                    leapyear = true;
                }
            }

            //output number of days in a month
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("30 days");
            }
            else if (month == 2)
            {
                //DateTime.IsLeapYear(year)
                if (leapyear) //same --> (leapyear == true)
                {
                    Console.WriteLine("29 days");
                }
                else
                {
                    Console.WriteLine("28 days");
                }
            }
            else
            {
                Console.WriteLine("31 days");
            }


            //version 2
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("31 days");
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("30 days");
            }
            else if (leapyear)
            {
                Console.WriteLine("29 days");
            }
            else
            {
                Console.WriteLine("28 days");
            }
            
            //version 3
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11: Console.WriteLine("30 days"); break;
                case 2:
                    if (leapyear) //same --> (leapyear == true)
                    {
                        Console.WriteLine("29 days");
                    }
                    else
                    {
                        Console.WriteLine("28 days");
                    }
                    break;
                default: Console.WriteLine("31 days"); break;
            }
        }
    }
}
