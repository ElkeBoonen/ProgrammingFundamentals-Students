using System;

namespace SoundOfThePolice___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter zone (inside/outside): ");
            string zone = Console.ReadLine();

            Console.Write("Enter nr of kms above speed limit: ");
            int kms;

            bool tryParse = Int32.TryParse(Console.ReadLine(), out kms);
            if (!tryParse)
            {
                Console.WriteLine("Kms was not a number! We stop execution!");
                return;
            }

            if (zone == "inside")
            {
                if (kms < 5)
                {
                    Console.WriteLine("No fee!");
                }
                else if (kms >= 5 && kms <= 9)
                {
                    Console.WriteLine("54 euro");
                }
                else if (kms >= 10 && kms <= 19)
                {
                    Console.WriteLine("107 euro");
                }
                else if (kms >= 20 && kms <= 24)
                {
                    Console.WriteLine("257 euro");
                }
                else
                {
                    Console.WriteLine("337 euro");
                }
            }
            else 
            {
                if (kms < 5)
                {
                    Console.WriteLine("No fee!");
                }
                else if (kms >= 5 && kms <= 9)
                {
                    Console.WriteLine("45 euro");
                }
                else if (kms >= 10 && kms <= 19)
                {
                    Console.WriteLine("90 euro");
                }
                else if (kms >= 20 && kms <= 24)
                {
                    Console.WriteLine("223 euro");
                }
                else
                {
                    Console.WriteLine("300 euro");
                }
            }


            if (kms < 5)
            {
                Console.WriteLine("No fee!");
            }
            else if (kms >= 5 && kms <= 9)
            {
                if (zone == "outside")
                {
                    Console.WriteLine("45 euro");
                }
                else
                {
                    Console.WriteLine("54 euro");
                }
                
            }
            else if (kms >= 10 && kms <= 19)
            {
                if (zone == "outside")
                {
                    Console.WriteLine("90 euro");
                }
                else
                {
                    Console.WriteLine("107 euro");
                }
            }
            else if (kms >= 20 && kms <= 24)
            {
                if (zone == "outside")
                {
                    Console.WriteLine("223 euro");
                }
                else
                {
                    Console.WriteLine("257 euro");
                }
            }
            else
            {
                if (zone == "outside")
                {
                    Console.WriteLine("300 euro");
                }
                else
                {
                    Console.WriteLine("337 euro");
                }
            }


            /*int speed = ... ; //read something in 
            int speedlimit =  ... ; //read something in

            if (speedlimit > 30) zone = "inside";
            kms = speed - speedlimit;

            //use same if-structure as above*/

        }
    }
}
