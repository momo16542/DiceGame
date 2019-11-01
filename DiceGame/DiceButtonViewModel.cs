using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class DiceButtonViewModel : ViewModelBase
    {
        public static List<DiceButtonViewModel> GetDiceButtonsViewModels()
        {
            List<DiceButtonViewModel> list = new List<DiceButtonViewModel>()
            {
                new DiceButtonViewModel(1,2){Text1="Small"},
                new DiceButtonViewModel(2,11){Text1="1 Double"},
                new DiceButtonViewModel(3,11){Text1="2 Double"},
                new DiceButtonViewModel(4,11){Text1="3 Double"},
                new DiceButtonViewModel(5,180){Text1="1 Triple"},
                new DiceButtonViewModel(6,180){Text1="2 Triple"},
                new DiceButtonViewModel(7,180){Text1="3 Triple"},
                new DiceButtonViewModel(8,30){Text1="Triple"},
                new DiceButtonViewModel(9,180){Text1="4 Triple"},
                new DiceButtonViewModel(10,180){Text1="5 Triple"},
                new DiceButtonViewModel(11,180){Text1="6 Triple"},
                new DiceButtonViewModel(12,11){Text1="4 Double"},
                new DiceButtonViewModel(13,11){Text1="5 Double"},
                new DiceButtonViewModel(14,11){Text1="6 Double"},
                new DiceButtonViewModel(15,2){Text1="Big"},
                new DiceButtonViewModel(16,60){Text1="4"},
                new DiceButtonViewModel(17,20){Text1="5"},
                new DiceButtonViewModel(18,18){Text1="6"},
                new DiceButtonViewModel(19,12){Text1="7"},
                new DiceButtonViewModel(20,8){Text1="8"},
                new DiceButtonViewModel(21,6){Text1="9"},
                new DiceButtonViewModel(22,6){Text1="10"},
                new DiceButtonViewModel(23,6){Text1="11"},
                new DiceButtonViewModel(24,6){Text1="12"},
                new DiceButtonViewModel(25,8){Text1="13"},
                new DiceButtonViewModel(26,12){Text1="14"},
                new DiceButtonViewModel(27,18){Text1="15"},
                new DiceButtonViewModel(28,20){Text1="16"},
                new DiceButtonViewModel(29,60){Text1="17"},
                new DiceButtonViewModel(30,6){Text1="1 and 2"},
                new DiceButtonViewModel(31,6){Text1="1 and 3"},
                new DiceButtonViewModel(32,6){Text1="1 and 4"},
                new DiceButtonViewModel(33,6){Text1="1 and 5"},
                new DiceButtonViewModel(34,6){Text1="1 and 6"},
                new DiceButtonViewModel(35,6){Text1="2 and 3"},
                new DiceButtonViewModel(36,6){Text1="2 and 4"},
                new DiceButtonViewModel(37,6){Text1="2 and 5"},
                new DiceButtonViewModel(38,6){Text1="2 and 6"},
                new DiceButtonViewModel(39,6){Text1="3 and 4"},
                new DiceButtonViewModel(40,6){Text1="3 and 5"},
                new DiceButtonViewModel(41,6){Text1="3 and 6"},
                new DiceButtonViewModel(42,6){Text1="4 and 6"},
                new DiceButtonViewModel(43,6){Text1="4 and 6"},
                new DiceButtonViewModel(44,6){Text1="5 and 6"},
                new DiceButtonViewModel(45){Text1="ONE"},
                new DiceButtonViewModel(46){Text1="TWO"},
                new DiceButtonViewModel(47){Text1="THREE"},
                new DiceButtonViewModel(48){Text1="FOUR"},
                new DiceButtonViewModel(49){Text1="FIVE"},
                new DiceButtonViewModel(50){Text1="SIX"}

            };

            return list;
        }
        public DiceButtonViewModel(int number, decimal odds)
        {
            Number = number;
            Bet = new BetPoco(number, odds);
        }
        public int Number { get; }
        public BetPoco Bet { get; }

        public string Text1
        {
            get { return _Text1; }
            set
            {
                _Text1 = value;
                OnPropertyChanged();
            }
        }
        private string _Text1;

        public string Text2
        {
            get { return _Text2; }
            set
            {
                _Text2 = value;
                OnPropertyChanged();
            }
        }
        private string _Text2;
    }
}
