using System;
using System.Drawing;
using Console = Colorful.Console;
//

namespace TIC_TAC_TOE___GROEP_A
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ttt = new TicTacToe();
            Console.WriteLine(ttt);

            Console.Write("Position? ");
            int position = Convert.ToInt32(Console.ReadLine());

            bool X = true;
            
            while (!ttt.Full())
            {
                if (X) ttt.MakeMove(position, 'X');
                else ttt.MakeMove(position, 'O');
                X = !X;

                Console.WriteLine(ttt, Color.FromArgb(255,0,0));

                if (ttt.Winner() != ' ')
                {
                    Console.WriteLine(ttt.Winner() + " is gewonnen!");
                    return;
                }

                Console.Write("Position? ");
                position = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("GELIJKSPEL!");
        }
    }
}
