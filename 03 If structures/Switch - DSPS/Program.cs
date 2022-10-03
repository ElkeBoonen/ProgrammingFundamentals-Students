using System;

namespace Switch___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekday = (int) DateTime.Now.DayOfWeek;

            //DateTime yesterday = new DateTime(2022, 10, 2); //--> sunday
            //weekday = (int)yesterday.DayOfWeek;

            if (weekday == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Thursday");
            }
            else {
                Console.WriteLine("Hooray! Weekend!");
            }

            switch (weekday)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                default: Console.WriteLine("Hooray! Weekend!");
                    break;
            }
        }
    }
}
