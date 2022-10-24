using System;

namespace _1D_ARRAY___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /************************************************/
            /****************** CREATE ARRAY ****************/
            /************************************************/
            int[] ints = new int[10];           //all values are 0
            string[] strings = new string[4];   //all values are ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);

            /************************************************/
            /****************** GET VALUES *++***************/
            /************************************************/
            Console.WriteLine("first element of ints: " + ints[0]);
            Console.WriteLine("last element of doubles: " + doubles[5]);
            Console.WriteLine("last element of doubles: " + doubles[doubles.Length-1]);
            Console.WriteLine("last element of doubles: " + doubles[^1]);

            /************************************************/
            /**************** ASSIGNING VALUES *++***********/
            /************************************************/
            strings[0] = "tuur";
            strings[1] = "jan";
            strings[2] = "mies";
            strings[3] = "bob";

            //strings[4] = "new baby"; --> no more kids ;) index out of range!

            Console.WriteLine("last element of doubles: " + doubles[^1]);
            doubles[5] = 1.0;
            Console.WriteLine("last element of doubles: " + doubles[^1]);

            /************************************************/
            /******************* LOOP ARRAYS *++*************/
            /************************************************/
            foreach (var item in strings) //--> looping when you don't need the index of an element
            {
                Console.WriteLine(item);
            }

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < doubles.Length; i++)    //looping when you need the index
            {
                Console.WriteLine(doubles[i]);
            }

            int index = 0;
            while (index < doubles.Length)              //never using for looping an array ;)
            {
                Console.WriteLine(doubles[index]);
                index++; //otherwise infinite loop
            }

            doubles = new double[] { 1,3,4,-1, -4, 55, 8, 89}; //overwrite the entire array
            foreach (var item in doubles)
            {
                Console.Write(item + " "); //same line, separated by a space
            }
            Console.WriteLine();

            /************************************************/
            /*********** FILL ARRAYS WITH FOR LOOP **********/
            /************************************************/
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i * 4;

                //fill array with user input
                //Console.Write($"Enter number index {i}: ");
                //ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in ints)
            {
                Console.Write(item + " "); //same line, separated by a space
            }
            Console.WriteLine();

            /************************************************/
            /******** FILL ARRAYS WITH SPLIT METHOD *********/
            /************************************************/
            Console.WriteLine("Enter animals, separated by a space");
            string answer = "cat elephant dog whale fox"; //Console.ReadLine();

            string[] animals = answer.Split(' ');
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter animals, separated by a ;");
            answer = "cat;elephant;dog;whale;fox"; //Console.ReadLine();

            animals = answer.Split(';');
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            /************************************************/
            /*** FILL & CONVERT ARRAYS WITH SPLIT METHOD ****/
            /************************************************/

            Console.WriteLine("Enter numbers, separated by a space");
            answer = "8 7 -1 5 6 9 0 10 -3"; //Console.ReadLine();

            string[] strArray = answer.Split(';');
            int[] intArray = new int[strArray.Length];

            for (int i = 0; i < intArray.Length; i++) //strArray.Length
            {
                intArray[i] = Convert.ToInt32(strArray[i]);
            }

            //convert the entire array
            intArray = Array.ConvertAll(strArray, Convert.ToInt32);

        }
    }
}
