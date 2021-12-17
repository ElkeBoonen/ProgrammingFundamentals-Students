using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLAD_STEEN_SCHAAR___IMSA
{
    class RPS
    {
        public int ScoreComputer { get; set; }
        public int ScoreUser { get; set; }
        private Random _random;
        public RPS()
        {
            _random = new Random();
            ScoreComputer = 0;
            ScoreUser = 0;
        }

        public Hand TurnComputer()
        {
            //random nummer tussen 0 en 3 --> 0, 1, 2
            //casten naar een Hand!
            return (Hand)_random.Next(0, 3);
        }

        public void Score(Hand computer, Hand user)
        {
            if (user == computer) return;

            if ((user == Hand.paper && computer == Hand.rock) ||
                (user == Hand.scissors && computer == Hand.paper) ||
                (user == Hand.rock && computer == Hand.scissors))
            {
                ScoreUser++;
            }
            else
            {
                ScoreComputer++;
            }
        }

        public override string ToString()
        {
            return $"USER {ScoreUser} - COMPUTER {ScoreComputer}";
        }
    }
}
