using System;

namespace PYRAMID___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Create these triangles
                *
                * *
                * * *
                * * * *
                
                * * * *
                * * *
                * *    *
                *    * *
                   * * *
                 * * * * 
                
                 * * * *
                   * * *
                     * *
                       *    */

            int x = 4;
            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i <=x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            /*
               *
             * *
           * * *  
             */

            Console.WriteLine();
            for (int i = 0; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
