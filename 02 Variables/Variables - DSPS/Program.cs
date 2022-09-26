using System;
using System.Linq;

namespace Variables___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;  //declaring! -> group variables with same type 
            x = 5;     //initialization -> giving it a first value
            y = 8;

            byte numberByte = 12; //declaration & initialization on same line
            //numberByte = 256; --> byte is too small!

            double numberDouble = 45.897676;
            //float numberFloat = numberDouble; error -> double can store bigger numbers

            float numberFloat = 56.89089f;
            numberDouble = numberFloat; //we can store a float in a double, because float is smaller!

            string name = "Elke";
            char character = ' '; //a space is also 1 character!
            name = "another name";

            Console.WriteLine(name);
            Console.WriteLine(numberByte);
            Console.WriteLine(numberDouble);
            Console.WriteLine(numberFloat);
            Console.WriteLine(character);

            Console.WriteLine("--> ++ and --");
            Console.WriteLine("x = " + x);
            x++;
            Console.WriteLine("x = " + x);
            --x;
            Console.WriteLine("x = " + x);

            Console.WriteLine("--> ++ and -- --> POSTFIX & PREFIX");
            Console.WriteLine($"x++ results in {x++}");
            Console.WriteLine($"++x results in {++x}");
            Console.WriteLine($"x-- results in {x--}");
            Console.WriteLine($"--x results in {--x}");

            Console.WriteLine("--> ARITHMETIC OPERATORS");
            Console.WriteLine($"{x}+{y}={x + y}");
            Console.WriteLine($"{x}-{y}={x - y}");
            Console.WriteLine($"{x}*{y}={x * y}");
            Console.WriteLine($"{x}/{y}={x / y}");      //integer division - cut off decimal part
            Console.WriteLine($"{5.0}/{y}={5.0 / y}");

            Console.WriteLine("--> MODULO");
            //remainder after integer division!!
            Console.WriteLine($"10 % 9 = {10 % 9}"); //10/9 = 1 --> remainder = 1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //10/8 = 1 --> remainder = 2
            Console.WriteLine($"10 % 7 = {10 % 7}"); //10/7 = 1 --> remainder = 3
            Console.WriteLine($"10 % 6 = {10 % 6}"); //10/6 = 1 --> remainder = 4
            Console.WriteLine($"10 % 5 = {10 % 5}"); //10/5 = 2 --> remainder = 0
            Console.WriteLine($"10 % 4 = {10 % 4}"); //10/4 = 2 --> remainder = 2
            Console.WriteLine($"10 % 3 = {10 % 3}"); //10/3 = 3 --> remainder = 1
            Console.WriteLine($"10 % 2 = {10 % 2}"); //10/2 = 5 --> remainder = 0
            Console.WriteLine($"10 % 1 = {10 % 1}"); //10/1 = 10 --> remainder = 0

            Console.WriteLine("--> MODULO without using %-operator");
            int resultAfterIntDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterIntDivision * 3)}");

            Console.WriteLine("--> COMPOUND OPERATORS");
            Console.WriteLine("x starts at " + x);
            x += 10;    // x = x + 10
            Console.WriteLine("x += 10  --> " + x);
            x -= 7;     // x = x - 7
            Console.WriteLine("x -= 7  --> " + x);
            x *= 4;
            Console.WriteLine("x *= 4  --> " + x);
            x /= 3;
            Console.WriteLine("x /= 3  --> " + x);
            x %= 5;
            Console.WriteLine("x %= 5  --> " + x);

            Console.WriteLine("--> COMPOUND OPERATORS - STRING");
            name = "Elke";
            name += " Boonen";          // add something at the back!
            Console.WriteLine(name);

            name = "Elke";
            name = "Boonen " + name;    // add something in front 
            Console.WriteLine(name);

            Console.WriteLine("--> COMPARISON OPERATORS");
            Console.WriteLine($"{x}<{y} -> {x < y}");
            Console.WriteLine($"{x}>{y} -> {x > y}");
            Console.WriteLine($"{x}<={y} -> {x <= y}");
            Console.WriteLine($"{x}>={y} -> {x >= y}");
            Console.WriteLine($"{x}=={y} -> {x == y}");
            Console.WriteLine($"{x}!={y} -> {x != y}");
            Console.WriteLine(x != y);

            Console.WriteLine("--> WEIRD THINGS ;)");
            Console.WriteLine(5 + 5);       //10
            Console.WriteLine("5" + 5);     //55
            Console.WriteLine('5' + 5);     //58 --> ascii value of '5' = 53
            Console.WriteLine('5' + '5');   //106
            Console.WriteLine("" + 5 + 5);  //55
            Console.WriteLine("" + (5 + 5));//10 --> because of the use of ( ) !

            Console.WriteLine("--> CHARACTERS IN STRINGS");
            name = "Elizabeth";
            char firstChar = name[0];
            Console.WriteLine($"First character of {name} is {firstChar}");

            firstChar = name.ElementAt(0);
            Console.WriteLine($"First character of {name} is {firstChar}");

            char lastChar = name[name.Length-1];
            Console.WriteLine($"Last character of {name} is {lastChar}");



        }
    }
}
