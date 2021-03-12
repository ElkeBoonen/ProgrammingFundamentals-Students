using System;

namespace If_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            string answer = Console.ReadLine();

            int x;
            bool success = Int32.TryParse(answer, out x);

            Console.WriteLine(x);
            if (!success) x = 5; //default value
            Console.WriteLine(x);

            //int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;

            Console.WriteLine("the start of another if-structure!!!");
            if (x < y)
            {
                Console.WriteLine("x is less then y");
            }
            if (x == y) //the start of another if-structure!!!
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is greater then y");
            }

            Console.WriteLine("another condition in the same if-structure!!");
            if (x < y)
            {
                Console.WriteLine("x is less then y");
            }
            else if (x == y) //another condition in the same if-structure!!
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is greater then y");
            }


            if (x < y)
            {
                Console.WriteLine("x is less then y");
            }
            else
            {
                if (x == y) //nested if-structure
                {
                    Console.WriteLine("x is equal to y");
                }
                else
                {
                    Console.WriteLine("x is greater then y");
                }
            }


            if (x <= y)
            {
                if (x == y)
                {
                    Console.WriteLine("x is equal to y");
                }
                else
                {
                    Console.WriteLine("x is less then y");
                }
            }
            else
            {
                Console.WriteLine("x is greater then y");
            }

            if ((x > y) || (x < y))
            {
                Console.WriteLine("x is not equal to y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }

            if ((x >= y) && (x <= y))
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not equal to y");
            }

            if (!(x > y) && !(x < y))
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not equal to y");
            }

            bool result = x == y;
            if (result)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is not equal to y");
            }

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.DayOfYear);
            Console.WriteLine(now.Second);
            int weekday = Convert.ToInt32(now.DayOfWeek);
            Console.WriteLine(weekday);

            if (weekday == 1) Console.WriteLine("It's a Monday");
            else if (weekday == 2) Console.WriteLine("It's a Tuesday");
            else if (weekday == 3) Console.WriteLine("It's a Wednesday");
            else if (weekday == 4) Console.WriteLine("It's a Thursday");
            else if (weekday == 5) Console.WriteLine("It's a Friday");
            else if (weekday == 6) Console.WriteLine("It's a Saturday");
            else if (weekday == 7) Console.WriteLine("It's a Sunday");
            else Console.WriteLine("Crazy day");

            switch (weekday)
            {
                case 1: Console.WriteLine("It's a Monday");
                    break;
                case 2: Console.WriteLine("It's a Tuesday");
                    break;
                case 3: Console.WriteLine("It's a Wednesday");
                    break;
                case 4: Console.WriteLine("It's a Thursday");
                    break;
                case 5: Console.WriteLine("It's a Friday");
                    break;
                case 6: Console.WriteLine("It's a Saturday");
                    break;
                case 7: Console.WriteLine("It's a Sunday");
                    break;
                default: Console.WriteLine("Crazy day");
                    break;
            }

        }
    }
}
