using System;
using System.Globalization;

namespace _2D_ARRAY___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******************************************************/
            /***************** CREATE 2D ARRAY ********************/
            /******************************************************/

            int[,] ints = new int[4, 5];
            string[,] fruit = {   { "apple","banana","starfruit","lemon" },
                                  { "lime", "mango","strawberry", "watermelon"},
                                  { "peach","orange","grapefruit", "pineapple"} };

            /******************************************************/
            /******************** GET VALUES **********************/
            /******************************************************/
            Console.WriteLine("element row 1 col 1: " + fruit[1, 1]);
            Console.WriteLine("element row 2 col 1: " + fruit[2, 1]);

            fruit[2, 1] = "pear";
            Console.WriteLine("element row 2 col 1: " + fruit[2, 1]);

            /******************************************************/
            /******************** LOOP ARRAY **********************/
            /******************************************************/

            Console.WriteLine(fruit.Length); //all elements
            Console.WriteLine("# rows: " + fruit.GetLength(0));
            Console.WriteLine("# cols: " + fruit.GetLength(1));

            for (int i = 0; i < fruit.GetLength(0); i++) //rows
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t");
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            /******************************************************/
            /******** FILL ARRAY RANDOM NRS CREATE SUM ************/
            /******************************************************/
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++) //rows
            {
                for (int j = 0; j < ints.GetLength(1); j++) //cols
                {
                    ints[i, j] = rd.Next(0, 21);
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
