using System;

namespace _03_Test_CodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = Console.ReadLine();
            int year;
            if (Int32.TryParse(answer, out year))
            {

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
                    else leapyear = true;
                }
                Console.WriteLine(leapyear);
            }
            else
            {
                Console.WriteLine("crazy input");
            }

            Console.WriteLine($"dit is {year} + {year} = {year}");
            Console.WriteLine("dit is " +  year + " + " + year + " = " + year);
        }
    }
}
