using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE___GROEP_A
{
    class TicTacToe
    {
        public char[,] Board { get; set; }

        public TicTacToe()
        {
            int index = 48;
            Board = new char[3, 3];
            for (int i = 0; i < Board.GetLength(0); i++) //over rijen 
            {
                for (int j = 0; j < Board.GetLength(1); j++) //over kolommen 
                {
                    Board[i, j] = (char)index;
                    index++;
                }
            }
        }

        public bool MakeMove(int position, char symbol)
        {
            if (position < 0 || position > 8) return false;
            
            int row = position / 3;
            int col = position % 3;

            if (Board[row, col] != 'X' && Board[row, col] != 'O')
            {
                Board[row, col] = symbol;
                return true;
            }
            return false;
        }

        public bool Full()
        {
            bool full = true;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (Board[i, j] != 'X' && Board[i, j] != 'O')
                    {
                        full = false;
                    }
                }
            }
            return full;
        }

        public char Winner()
        {
            char winner = ' ';
            //horizontal
            if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0, 2]) winner = Board[0, 0];
            if (Board[1, 0] == Board[1, 1] && Board[1, 1] == Board[1, 2]) winner = Board[1, 0];
            if (Board[2, 0] == Board[2, 1] && Board[2, 1] == Board[2, 2]) winner = Board[2, 0];

            //vertical
            if (Board[0, 0] == Board[1, 0] && Board[1, 0] == Board[2, 0]) winner = Board[0, 0];
            if (Board[0, 1] == Board[1, 1] && Board[1, 1] == Board[2, 1]) winner = Board[0, 1];
            if (Board[0, 2] == Board[1, 2] && Board[1, 2] == Board[2, 2]) winner = Board[0, 2];

            //diagonal
            if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 1]) winner = Board[0, 0];
            if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0]) winner = Board[0, 2];
            return winner;

        }

        public override string ToString()
        {
            string s = "-------\n"; ;
            for (int i = 0; i < Board.GetLength(0); i++) //over rijen 
            {
                s += "|";
                for (int j = 0; j < Board.GetLength(1); j++) //over kolommen 
                {
                    s += Board[i, j] + "|" ;
                }
                s += "\n-------\n";
            }
            return s;
        }
    }
}
