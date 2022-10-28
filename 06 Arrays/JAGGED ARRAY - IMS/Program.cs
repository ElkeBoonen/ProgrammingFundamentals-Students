using System;

namespace JAGGED_ARRAY___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***********************************************/
            /*************** JAGGED AANMAKEN ***************/
            /***********************************************/

            int[][] ints = new int[2][];
            ints[0] = new int[4];
            ints[1] = new int[3];

            //0 0 0 0
            //0 0 0

            string[][] strings = {
                    new string[]{ "jan","piet","joris","korneel" },
                    new string[] { "eva","marie","ella","kim"} 
            };

            /***********************************************/
            /*************** JAGGED ELEMENTEN **************/
            /***********************************************/

            //0 0 0 5
            //0 2 0

            ints[0][3] = 5;
            ints[1][1] = 2;

            Console.WriteLine(strings[1][2]);
            strings[1][2] = "gloria";
            Console.WriteLine(strings[1][2]);

            /***********************************************/
            /*************** JAGGED OVERLOPEN **************/
            /***********************************************/

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    Console.Write(ints[i][j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (var item in ints)
            {
                foreach (var element in item)
                {
                    sum += element;
                }
            }
            Console.WriteLine("De som: " + sum);
        }
    }
}
