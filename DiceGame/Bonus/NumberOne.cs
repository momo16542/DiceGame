using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class NumberOne : IDistributeBonus
    {
        public decimal DistributeBonus(decimal bet)
        {
            return bet * 2;
        }
    }
}
