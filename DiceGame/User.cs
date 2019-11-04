using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class User : ViewModelBase
    {
        public decimal Points
        {
            get { return _Points; }
            private set
            {
                _Points = value;
                OnPropertyChanged();
            }
        }
        private decimal _Points;

        public void AddPoints(decimal points)
        {
            Points += points;
        }
        public void MinusPoints(decimal points)
        {
            Points -= points;
        }
        public void WithdrawPoints()
        {
            Points =0;
        }
    }
}
