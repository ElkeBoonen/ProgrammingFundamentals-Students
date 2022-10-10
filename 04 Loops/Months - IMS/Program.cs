using System;

namespace Months___IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een maand in: ");

            int month = Convert.ToInt32(Console.ReadLine());
            int year = DateTime.Now.Year;

            //int days = DateTime.DaysInMonth(year, month);

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("30 dagen");
            }
            else if (month == 2 && DateTime.IsLeapYear(year))
            {
                Console.WriteLine("29 dagen");
            }
            else if (month == 2 && !DateTime.IsLeapYear(year))
            {
                Console.WriteLine("28 dagen");
            }
            else
            {
                Console.WriteLine("31 dagen");
            }

            //versie 2
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("30 dagen");
            }
            else if (month == 2)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("29 dagen");
                }
                else
                {
                    Console.WriteLine("28 dagen");
                }

            }
            else
            {
                Console.WriteLine("31 dagen");
            }

            //versie 3
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11: Console.WriteLine("30 dagen"); break;
                case 2:
                    if (DateTime.IsLeapYear(year))
                    {
                        Console.WriteLine("29 dagen");
                    }
                    else
                    {
                        Console.WriteLine("28 dagen");
                    }
                    break;
                default: Console.WriteLine("31 dagen"); break;
            }
        }
    }
}
