using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class Small : WinFuction
    {
        public override bool IsWin(int[] dicePoints)
        {
            var result = dicePoints.Sum();
            return result > 4 && result < 10;
        }
    }
}
