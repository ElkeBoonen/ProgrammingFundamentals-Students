using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLAD_STEEN_SCHAAR___GROEP_B
{
    class BSS
    {
        public int ScoreGebruiker { get; set; }
        public int ScoreComputer { get; set; }

        private Random _random;

        public BSS()
        {
            ScoreGebruiker = 0;
            ScoreComputer = 0;
            _random = new Random();
        }

        public Hand Computer()
        {
            int index = _random.Next(0, 3);
            //if (index == 0) return Hand.blad;
            //else if ...
            return (Hand)index; //casten naar Hand doordat enum vaste collectie van waarden is
        }

        public void Score(Hand computer, Hand gebruiker)
        {
            if (computer == gebruiker) return;

            if ((computer == Hand.blad && gebruiker == Hand.steen) ||
                (computer == Hand.schaar && gebruiker == Hand.blad) ||
                (computer == Hand.steen && gebruiker == Hand.schaar))
            {
                ScoreComputer++;
            }
            else ScoreGebruiker++;
        }

        public override string ToString()
        {
            return "Gebruiker: " + ScoreGebruiker + " - " + " Computer: " + ScoreComputer;
        }
    }
}
