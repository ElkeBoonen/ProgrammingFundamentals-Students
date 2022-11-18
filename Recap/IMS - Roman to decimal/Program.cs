using System;

namespace IMS___Roman_to_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman = Console.ReadLine();
            int number = 0;
            foreach (char c in roman)
            {
                switch (c)
                {
                    case 'M': number += 1000;
                        break;
                    case 'D': number += 500;
                        break;
                    case 'C': number += 100;
                        break;
                    case 'L': number += 50;
                        break;
                    case 'X': number += 10;
                        break;
                    case 'V': number += 5;
                        break;
                    case 'I': number += 1;
                        break;
                    //als je echt default wilt hebben
                    //default: number += 0;
                    //    break;
                }

                /* alternatief
                if (c == 'M')
                {
                    number += 1000;
                }
                else if (c == 'D')
                {
                    number += 500;
                }*/
            }
            Console.WriteLine(number);
        }
    }
}
