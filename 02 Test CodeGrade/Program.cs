using System; 

namespace _02_Test_CodeGrade
{

    /*
     Input an integer (<= 255) and convert it to a binary number. (see Computer toolkit for more information on binary numbers)

        input
        57
        output
        00111001

        253/2=126⇒remainder 1
        126/2=63⇒remainder 0
        63/2=31⇒remainder 1
        31/2=15⇒remainder 1
        15/2=7⇒remainder 1
        7/2=3⇒remainder 1
        3/2=1⇒remainder 1
        1/2=0⇒remainder 1

     */

    class Program
    {
        static void Main(string[] args)
        {
            //
            int number = Convert.ToInt32(Console.ReadLine()); //253

            Console.WriteLine(Convert.ToString(number, 2));

            int b0 = number % 2;
            number /= 2; //number = number / 2
            int b1 = number % 2;
            number /= 2;
            int b2 = number % 2;
            number /= 2;
            int b3 = number % 2;
            number /= 2;
            int b4 = number % 2;
            number /= 2;
            int b5 = number % 2;
            number /= 2;
            int b6 = number % 2;
            number /= 2;
            int b7 = number % 2;

            Console.WriteLine($"{b7}{b6}{b5}{b4}{b3}{b2}{b1}{b0}");

            


        }
    }
}
