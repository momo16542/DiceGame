using DiceGame.Bonus;
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
                new DiceButtonViewModel(1,new Small(){ Odds =1 }){Text1="Small"},
                new DiceButtonViewModel(2,new DoubleDice(1){ Odds =11}){Text1="1 Double"},
                new DiceButtonViewModel(3,new DoubleDice(2){ Odds =11}){Text1="2 Double"},
                new DiceButtonViewModel(4,new DoubleDice(3){ Odds =11}){Text1="3 Double"},
                new DiceButtonViewModel(5,new TripleDice(1){ Odds =180}){Text1="1 Triple"},
                new DiceButtonViewModel(6,new TripleDice(2){ Odds =180}){Text1="2 Triple"},
                new DiceButtonViewModel(7,new TripleDice(3){ Odds =180}){Text1="3 Triple"},
                new DiceButtonViewModel(8,new TripleDice(true){ Odds =30}){Text1="Triple"},
                new DiceButtonViewModel(9,new TripleDice(4){ Odds =180}){Text1="4 Triple"},
                new DiceButtonViewModel(10,new TripleDice(5){ Odds =180}){Text1="5 Triple"},
                new DiceButtonViewModel(11,new TripleDice(6){ Odds =180}){Text1="6 Triple"},
                new DiceButtonViewModel(12,new DoubleDice(4){ Odds =11}){Text1="4 Double"},
                new DiceButtonViewModel(13,new DoubleDice(5){ Odds =11}){Text1="5 Double"},
                new DiceButtonViewModel(14,new DoubleDice(6){ Odds =11}){Text1="6 Double"},
                new DiceButtonViewModel(15,new Big(){ Odds =1 }){Text1="Big"},
                new DiceButtonViewModel(16,new TotalDicePoints(4){ Odds=60}){Text1="4"},
                new DiceButtonViewModel(17,new TotalDicePoints(5){ Odds=20}){Text1="5"},
                new DiceButtonViewModel(18,new TotalDicePoints(6){ Odds=18}){Text1="6"},
                new DiceButtonViewModel(19,new TotalDicePoints(7){ Odds=12}){Text1="7"},
                new DiceButtonViewModel(20,new TotalDicePoints(8){ Odds=8}){Text1="8"},
                new DiceButtonViewModel(21,new TotalDicePoints(9){ Odds=6}){Text1="9"},
                new DiceButtonViewModel(22,new TotalDicePoints(10){ Odds=6}){Text1="10"},
                new DiceButtonViewModel(23,new TotalDicePoints(11){ Odds=6}){Text1="11"},
                new DiceButtonViewModel(24,new TotalDicePoints(12){ Odds=6}){Text1="12"},
                new DiceButtonViewModel(25,new TotalDicePoints(13){ Odds=8}){Text1="13"},
                new DiceButtonViewModel(26,new TotalDicePoints(14){ Odds=12}){Text1="14"},
                new DiceButtonViewModel(27,new TotalDicePoints(15){ Odds=18}){Text1="15"},
                new DiceButtonViewModel(28,new TotalDicePoints(16){ Odds=20}){Text1="16"},
                new DiceButtonViewModel(29,new TotalDicePoints(17){ Odds=60}){Text1="17"},
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
                new DiceButtonViewModel(45,new SingleDicePoints(1)){Text1="ONE"},
                new DiceButtonViewModel(46,new SingleDicePoints(2)){Text1="TWO"},
                new DiceButtonViewModel(47,new SingleDicePoints(3)){Text1="THREE"},
                new DiceButtonViewModel(48,new SingleDicePoints(4)){Text1="FOUR"},
                new DiceButtonViewModel(49,new SingleDicePoints(5)){Text1="FIVE"},
                new DiceButtonViewModel(50,new SingleDicePoints(6)){Text1="SIX"}

            };

            return list;
        }
        WinFuction winFuction;
        public DiceButtonViewModel(int number, WinFuction win)
        {
            winFuction = win;
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
