using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class Big : WinFuction
    {      

        public override bool IsWin(int[] dicePoints)
        {
           var result= dicePoints.Sum();
            return result > 11 && result < 17;
        }
    }
}
