using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class TotalDicePoints : WinFuction
    {
        int dicePoint;
        public TotalDicePoints(int _dicePoints)
        {
            dicePoint = _dicePoints;
        }
        public override bool IsWin(int[] dicePoints)
        {
            var total = dicePoints.Sum();
            return total == dicePoint;
        }
    }
}
