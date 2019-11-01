using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class DoubleDice : WinFuction
    {
        int dicePoint;
        public DoubleDice(int _dicePoints)
        {
            dicePoint = _dicePoints;
        }
        public override bool IsWin(int[] dicePoints)
        {
            var count = dicePoints.Count(x => x == dicePoint);
            return count >= 2;
        }
    }
}
