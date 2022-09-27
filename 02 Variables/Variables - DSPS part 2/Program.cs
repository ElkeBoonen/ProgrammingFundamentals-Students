using System;

namespace Variables___DSPS_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check if a number is between 10 and 100
            //use / or %-operator

            int number = 7; 
            Console.WriteLine(number>10 && number<100); // && = AND
            int result = number / 10;   
            Console.WriteLine(result >= 1 && result <= 10);
            int resultMod100 = 100 % number;
            Console.WriteLine(resultMod100 < 100 && resultMod100 > 10);

            number = 78;
            Console.WriteLine(number > 10 && number < 100);
            result = number / 10;
            Console.WriteLine(result >= 1 && result <= 10);
            resultMod100 = number % 100;
            Console.WriteLine(resultMod100 < 100 && resultMod100 > 10);

            Console.WriteLine("--> INPUT/OUTPUT NEWLINES");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("--> INPUT CONVERTING");
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            number = Convert.ToInt32(answer);

            Console.WriteLine(number > 10 && number < 100);
            result = number / 10;
            Console.WriteLine(result >= 1 && result <= 10);
            resultMod100 = number % 100;
            Console.WriteLine(resultMod100 < 100 && resultMod100 > 10);

            Console.WriteLine("--> INPUT CONVERTING");
            Console.Write("Enter a byte: ");
            answer = Console.ReadLine();
            byte b = Convert.ToByte(answer);

            Console.Write("Enter a short: ");
            answer = Console.ReadLine();
            short s = Convert.ToInt16(answer); //Int16 = short, Int32 = int, Int64 = long

            Console.WriteLine(s);               // implicit conversion
            Console.WriteLine(s.ToString());    // explicit conversion

            Console.Write("Enter a character: ");
            answer = Console.ReadLine();
            char c = Convert.ToChar(answer);

            Console.WriteLine(c);
            Console.WriteLine((int)c); //ascii value

            // int nameToNumber = (int)name; --> will never work
            // int stringNumber = (int)"89"; --> will never work
            int stringNumber = Convert.ToInt32("89");

            number = (int)78.8989;
            double doubleNumber = (double)78;





        }
    }
}
