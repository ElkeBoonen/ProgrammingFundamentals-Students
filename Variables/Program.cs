using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring & initializing variables
            int numberA, numberB;
            numberA = 5;
            numberB = 10;
            numberB = 23;

            double numberC = 45.45;

            //swap numberA and numberB
            Console.WriteLine(numberA + " " + numberB);
            int swap = numberA;
            numberA = numberB;
            numberB = swap;
            Console.WriteLine(numberA + " " + numberB);

            //binary operators / * - + % (you need 2 operands!)
            Console.WriteLine("A = " + numberA + " B " + numberB); //A = 23 B = 5
            Console.WriteLine(numberA + numberB);  //28
            Console.WriteLine(numberA - numberB);  //18
            Console.WriteLine(numberA / numberB);  //4
            Console.WriteLine(23.0 / 5);           //4.6
            Console.WriteLine(numberA * numberB);  //115
            Console.WriteLine(numberA % numberB);  //3
            //23/5 = 4 --> 4*5=20 23-20=3 = remainder after integer division!!!

            //unary operator (only 1 operand)
            Console.WriteLine("UNARY OPERATORS 1 ");
            numberA++;
            Console.WriteLine(numberA);
            numberA--;
            Console.WriteLine(numberA);
            ++numberA;
            Console.WriteLine(numberA);
            --numberA;
            Console.WriteLine(numberA);

            Console.WriteLine("UNARY OPERATORS 2 ");
            Console.WriteLine(numberA++);
            Console.WriteLine(numberA--);
            Console.WriteLine(++numberA);
            Console.WriteLine(--numberA);

            string word = "this is a string";
            string characterA = "a";
            char characterB = 'b';

            Console.WriteLine("Strings!");
            Console.WriteLine(5 + 5);
            Console.WriteLine("5" + 5);
            Console.WriteLine(5 + "5");

            Console.Write("Give a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine($"Hello name"); //use { } !!
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Hello {0}", name);

            Console.Write("Give a number: ");
            string answer = Console.ReadLine();
            double number = Convert.ToDouble(answer);

            /*Console.Write("Give another number: ");
            double numberD = Convert.ToDouble(Console.ReadLine());*/

            Console.WriteLine($"Number is {number} ");
            int numberI = (int)number;
            Console.WriteLine($"Casted number is {numberI} ");

            char a = 'a';
            int asciiOfA = (int)a;
            Console.WriteLine(a + " has ASCII value of " + asciiOfA);
            Console.Write("Give an ascii value: ");
            int ascii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((char)ascii + " has ASCII value of " + ascii);
            Console.WriteLine((char)(ascii+1) + " is next character in ASCII table");

        }
    }
}
