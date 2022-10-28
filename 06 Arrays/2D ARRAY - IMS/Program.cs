using System;

namespace _2D_ARRAY___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*****************************************/
            /*********** 2D ARRAY AANMAKEN ***********/
            /*****************************************/

            int[,] ints = new int[2, 4];
            //0 0 0 0
            //0 0 0 0

            string[,] strings = {   { "jan", "piet"} , 
                                    { "joris", "korneel"},
                                    { "marie", "jozefien"} };
            //jan piet
            //joris korneel
            //marie jozefien

            /*****************************************/
            /*********** 2D ARRAY ELEMENTEN **********/
            /*****************************************/

            //waarde voor , = rij
            //waarde na , = kolom

            //0 4 0 3
            //0 1 0 0
            ints[0, 3] = 3;
            ints[0, 1] = 4;
            ints[1, 1] = 1;

            //marie vervangen door maria
            Console.WriteLine(strings[2, 0]);
            strings[2, 0] = "maria";
            Console.WriteLine(strings[2, 0]);

            /*****************************************/
            /*********** 2D ARRAY OVERLOPEN **********/
            /*****************************************/

            for (int i = 0; i < ints.GetLength(0); i++) //lopen over de rijen
            {
                for (int j = 0; j < ints.GetLength(1); j++) //lopen over de kolommen
                {
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }

            //je kan een foreach gebruiken als de dimensies niet belangrijk zijn!
            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }
            Console.WriteLine("De som is: " + sum);
        }
    }
}
