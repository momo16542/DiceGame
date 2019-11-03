using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    public abstract class WinFuction
    {
        public abstract bool IsWin(int[] dicePoints);
        public decimal Odds { get; set; }
        public decimal GetBonus(decimal bet)
        {
            return bet * Odds;
        }

    }
}
