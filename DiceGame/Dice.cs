using DiceGame.Bonus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Dice
    {
        public int[] DrawDice()
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            int[] result = new int[3] { r1.Next(1, 7), r2.Next(1, 7), r3.Next(1, 7) };
            return result;
        }        
        public decimal DistributeBonus(int[] dicePoint, WinFuction winFuction, BetPoco bet)
        {
            decimal bonus = 0;
            if (winFuction.IsWin(dicePoint))
            {
                bonus = winFuction.GetBonus(bet.Bets);
            }
            return bonus;
        }
    }
}
