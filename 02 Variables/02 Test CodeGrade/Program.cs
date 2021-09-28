using System;

namespace _02_Test_CodeGrade
{
    class Program
    {
        /*
         Input an integer (<= 255) and convert it to a binary number. 
         (see Computer toolkit for more information on binary numbers)

            input
            57
            output
            00111001

         */

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int getal = Convert.ToInt32(input);

            int r0 = 0, r1=0, r2=0, r3=0, r4=0, r5=0, r6=0, r7=0;

            r0 = getal % 2;
            getal /= 2;     //hetzelfde als getal = getal / 2
            r1 = getal % 2;
            getal /= 2;
            r2 = getal % 2;
            getal /= 2;
            r3 = getal % 2;
            getal /= 2;
            r4 = getal % 2;
            getal /= 2;
            r5 = getal % 2;
            getal /= 2;
            r6 = getal % 2;
            getal /= 2;
            r7 = getal % 2;

            Console.WriteLine($"{r7}{r6}{r5}{r4}{r3}{r2}{r1}{r0}");
            //Console.WriteLine("" + r7+r6+r5+r4+r3+r2+r1+r0);
        }
    }
}
