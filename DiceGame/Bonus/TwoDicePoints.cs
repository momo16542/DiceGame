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
            Odds = 6;
        }

        public override bool IsWin(int[] dicePoints)
        {
            var count = dicePoints.GroupBy(x=>x).Count(x => x.Key == dicePoint1 || x.Key == dicePoint2);            

            return count ==2;
        }

    }
}
