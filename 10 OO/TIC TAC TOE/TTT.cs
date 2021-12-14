using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    class TTT
    {//drie op een rij

        public int ScoreGebruiker { get; set; }
        public int ScoreComputer { get; set; }

        public string[,] Spelbord { get; set; }

        public TTT()
        {
            ScoreComputer = 0;
            ScoreGebruiker = 0;
            Spelbord = new string[3, 3];
            for (int i = 0; i < Spelbord.GetLength(0); i++)
            {
                for (int j = 0; j < Spelbord.GetLength(1); j++)
                {
                    Spelbord[i, j] = $"{i},{j}";
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Spelbord.GetLength(0); i++)
            {
                for (int j = 0; j < Spelbord.GetLength(1); j++)
                {
                    s += Spelbord[i, j] + "\t";
                }
                s += "\n";
            }
            return s;
        }

    }
}
