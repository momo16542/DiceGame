﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    class SingleDicePoints : WinFuction
    {
        int dicePoint;
        public SingleDicePoints(int _dicePoints)
        {
            dicePoint = _dicePoints;
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
