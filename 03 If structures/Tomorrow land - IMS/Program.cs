using System;

namespace Tomorrow_land___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender: ");
            char gender  = Convert.ToChar(Console.ReadLine());

            if (age >= 18 && age <= 30)
            {
                //if (gender.Equals('F'))
                if (gender == 'F') //phase 2
                {
                    Console.WriteLine("Can enter");
                }
                else
                {
                    Console.Write("Do you want to play 100 euro? (yes/no): ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.WriteLine("Can enter");
                    }
                    else
                    {
                        Console.WriteLine("Can not enter");
                    } 
                }
               
            }
            else
            {
                Console.WriteLine("Can not enter");
            }


            /*if (age > 30 && age < 18)
            {
                Console.WriteLine("Can not enter");
            }
            else
            {
                Console.WriteLine("Can enter");
            }*/
        }
    }
}
