using System;
using System.Linq; //we gebruiken de LINQ-namespace!!!

namespace _04_Test_CodeGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
             Take a look at computer toolkit!
                input
                10000000

                output
                128
             */

            string binair = Console.ReadLine();
            int getal = 0;

            for (int i = 0; i < binair.Length; i++)
            {
                if (binair.ElementAt(i) == '1')
                {
                    getal += (int)Math.Pow(2, binair.Length - i-1);
                    //Console.WriteLine("hoera");
                }
            }
            Console.WriteLine(getal);


            /*hoe van decimaal naar binair???
             * 
             * while --> zolang getal > 0, getal % 2, getal / 2 --> rest bijhounden!!!
             * 
             * */


        }   
    }
}
