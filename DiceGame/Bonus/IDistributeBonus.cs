using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Bonus
{
    interface IDistributeBonus
    {
        decimal DistributeBonus(decimal bet);
    }
}
