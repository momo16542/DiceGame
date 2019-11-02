using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class BetPoco
    {
        public BetPoco(int number, decimal odds)
        {
            Number = number;
            this.odds = odds;
        }
        public int Number { get; }
        private decimal bets;
        private readonly decimal odds;
        public void AddBets(decimal bets)
        {
            this.bets += bets;
        }
        public void RemoveBets(decimal bets)
        {
            this.bets -= bets;
            if (this.bets <= 0)
            {
                this.bets = 0;
            }
        }      
        public decimal GetBonus()
        {
            var bonus = bets * odds;
            return bonus > 0 ? bonus : 0;
        }

    }
}
