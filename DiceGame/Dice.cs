using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Dice
    {
        public int DrawDice()
        {
            Random r = new Random();
            var result = r.Next(1, 7);
            return result;
        }
        public decimal DistributeBonus(List<BetPoco> list)
        {
            decimal bonus = 0;
            foreach (var item in list)
            {
                bonus += item.GetBonus();
            }

            return bonus;
        }
    }
}
