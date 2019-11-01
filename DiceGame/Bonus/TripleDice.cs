using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class TripleDice : WinFuction
    {
        int dicePoint;
        bool anyTriple;
        public TripleDice(int _dicePoints)
        {
            dicePoint = _dicePoints;
        }
        public TripleDice(bool _anyTriple)
        {
            anyTriple = _anyTriple;            
        }
        public override bool IsWin(int[] dicePoints)
        {
            if (anyTriple)
            {
                var count = dicePoints.GroupBy(x => x).Count();
                return count == 1;
            }
            else
            {
                var count = dicePoints.Count(x => x == dicePoint);
                return count >= 3;
            }


        }
    }
}
