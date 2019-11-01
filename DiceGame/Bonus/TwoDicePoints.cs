using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class TwoDicePoints : WinFuction
    {
        int dicePoint1;
        int dicePoint2;
        public TwoDicePoints(int _dicePoint1, int _dicePoint2)
        {
            dicePoint1 = _dicePoint1;
            dicePoint2 = _dicePoint2;
        }

        public override bool IsWin(int[] dicePoints)
        {
            var count = dicePoints.Count(x => x == dicePoint);
            if (count == 1)
            {
                Odds = 1;
            }
            else if (count == 2)
            {
                Odds = 2;
            }
            else if (count == 2)
            {
                Odds = 3;
            }

            return count > 0;
        }

    }
}
