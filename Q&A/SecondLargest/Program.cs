using System;

namespace SecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 10, 8, 7, 5, 5, 12, 10, 9, 13, 8, 8, 5, 13, 13, 14, 15, 14, 15, 15 };
            //Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32)

            //bubble sort
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < (array[j + 1])) //ik wil aflopend sorteren!!!!
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            //GEBRUIK BREAKPOINTS OM TE TESTEN!!
            //OF PRINT AF ZOALS HIERONDER
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            //2e grootste is het eerste getal dat anders is!
            bool flag = true;
            foreach (var item in array)
            {
                if (item != array[0] && flag)
                {
                    Console.WriteLine("\n" + item);
                    flag = false;
                }
            }

            foreach (var item in array)
            {
                if (item != array[0])
                {
                    Console.WriteLine("\n" + item);
                    return;
                }
            }


        }
    }
}
