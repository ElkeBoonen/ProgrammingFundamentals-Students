using System;

namespace It_s_magic
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[nr][];
            for (int i = 0; i < nr; i++)
            {
                string input = Console.ReadLine();
                array[i] = Array.ConvertAll(input.Split(' '), Convert.ToInt32);
            }

            int[] sums = new int[array[0].Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sums[j] += array[i][j];
                }
            }

            bool magic = true;
            foreach (var item in sums)
            {
                if (item != sums[0])
                {
                    magic = false;
                    //Console.WriteLine(false);
                    //return;
                }
            }
            //Console.WriteLine(true);
            Console.WriteLine(magic);

        }
    }
}
