using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class BetPoco : ViewModelBase
    {
        public BetPoco(int number)
        {
            Number = number;

        }
        public int Number { get; }


        public decimal Bets
        {
            get { return _Bets; }
            set
            {
                _Bets = value;
                OnPropertyChanged();
            }
        }
        private decimal _Bets;
        public void AddBets(decimal bets)
        {
            this.Bets += bets;
        }
        public void RemoveBets(decimal bets)
        {
            this.Bets -= bets;
            if (this.Bets <= 0)
            {
                this.Bets = 0;
            }
        }

        internal void ClearBets()
        {
            Bets = 0;
        }
    }
}
