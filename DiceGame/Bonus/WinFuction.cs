using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    abstract class WinFuction
    {     
        public abstract bool IsWin(int[] dicePoints);
        public decimal Odds { get; set; }
    }
}
