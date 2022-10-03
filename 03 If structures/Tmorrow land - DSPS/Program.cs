using System;

namespace Tmorrow_land___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gender: ");
            char gender = Convert.ToChar(Console.ReadLine());


            if (age >= 18 && age < 30)
            {
                if (gender == 'F')
                {
                    Console.WriteLine("Can enter!");
                }
                else 
                {
                    if (age > 20)
                    {
                        Console.WriteLine("Can enter!");
                    }
                    else
                    { 
                        Console.WriteLine("Do you want to pay extra? (no/yes)");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            Console.WriteLine("Can enter!");
                        }
                        else 
                        {
                            Console.WriteLine("Can not enter!");
                        }
                    }
                }
            }
            else 
            {
                Console.WriteLine("Can not enter!");
            }



            /*//PHASE 2
            if (gender == 'M' && (age > 20 && age < 30))
            {
                Console.WriteLine("Can enter!");
            }
            else if (gender == 'F' && age >= 18 && age < 30)
            {
                Console.WriteLine("Can enter!");
            }
            else
            {
                Console.WriteLine("Can not enter!");
            }

            //another version of phase 2
            if (gender == 'M')
            {
                if (age > 20 && age < 30)
                {
                    Console.WriteLine("Can enter!");
                }
                else
                {
                    Console.WriteLine("Can not enter!");
                }
            }
            else {
                if (age >= 18 && age < 30)
                {
                    Console.WriteLine("Can enter!");
                }
                else
                {
                    Console.WriteLine("Can not enter!");
                }

            }*/



                //PHASE 1 
                /* if (age >= 18 && age < 30)
               {
                   Console.WriteLine("Can enter!");
               }
               else 
               {
                   Console.WriteLine("Can not enter");
               }*/
        }
    }
}
