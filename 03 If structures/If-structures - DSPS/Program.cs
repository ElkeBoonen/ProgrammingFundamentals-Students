using System;

namespace If_structures___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number;
            
            bool convert = Int32.TryParse(Console.ReadLine(), out number);
            if (!convert) // == false
            {
                Console.WriteLine("Input was not correct, we are using our default value 67");
                number = 67; //default value
                // return;  //stop execution
            }
            
            if (number < 100)
            {
                Console.WriteLine("Number is smaller than 100");
            }
            else if (number == 100)
            {
                Console.WriteLine("Number is equal to 100");
            }
            else
            {
                Console.WriteLine("Number is greater than 100");
            }

            //we need the else-statement before another if !!!
            if (number < 100) //new if-statement
            {
                Console.WriteLine("Number is smaller than 100");
            }
            if (number == 100) //another new if-statement, it's not part of the other if-statement without else!!
            {
                Console.WriteLine("Number is equal to 100");
            }
            else
            {
                Console.WriteLine("Number is greater than 100");
            }

            //version 2 --> another if-structure in the else-block
            if (number < 100)
            {
                Console.WriteLine("Number is smaller than 100");
            }
            else
            {
                if (number == 100)
                {
                    Console.WriteLine("Number is equal to 100");
                }
                else
                {
                    Console.WriteLine("Number is greater than 100");
                }
            }

            //version 3 --> another if-structure in if-block
            if (number != 100)
            {
                if (number < 100)
                {
                    Console.WriteLine("Number is smaller than 100");
                }
                else
                {
                    Console.WriteLine("Number is greater than 100");
                }
            }
            else
            {
                Console.WriteLine("Number is equal to 100");
            }

            //version 4 --> another if-structure in else-block
            if (number > 100)
            {
                Console.WriteLine("Number is greater than 100");
            }
            else
            {
                if (number < 100)
                {
                    Console.WriteLine("Number is smaller than 100");
                }
                else
                {
                    Console.WriteLine("Number is equal to 100");
                }
            }

            /////////////////////////////////////ART OF COMBINING!!!!
            //check if number is (not) equal to 100
            //version 1
            if (number == 100)
            {
                Console.WriteLine("Number is equal to 100");
            }
            else
            {
                Console.WriteLine("Number is not equal to 100");
            }

            //version 2
            if (number < 100 || number > 100)
            {
                Console.WriteLine("Number is not equal to 100");
            }
            else
            {
                Console.WriteLine("Number is equal to 100");
            }
            //version 3
            if (number != 100)
            {
                Console.WriteLine("Number is not equal to 100");
            }
            else
            {
                Console.WriteLine("Number is equal to 100");
            }

            //version 4
            if (! (number == 100) )
            {
                Console.WriteLine("Number is not equal to 100");
            }
            else
            {
                Console.WriteLine("Number is equal to 100");
            }

            //version 5
            if ( number == 100 && !(number!=100))
            {
                Console.WriteLine("Number is equal to 100");
            }
            else
            {
                Console.WriteLine("Number is not equal to 100");
            }

            //version 6
            bool condition = number != 100;
            if (condition) //condition == true
            {
                Console.WriteLine("Number is not equal to 100");
            }
            else
            {
                Console.WriteLine("Number is equal to 100");
            }

            //version 7
            if (!condition) //condition == false
            {
                Console.WriteLine("Number is equal to 100");
            }
            else
            {
                Console.WriteLine("Number is not equal to 100");
            }


        }
    }
}
