using DiceGame.Bonus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceGame
{
    class DiceButtonViewModel : ViewModelBase
    {
        public static List<DiceButtonViewModel> GetDiceButtonsViewModels()
        {
            List<DiceButtonViewModel> list = new List<DiceButtonViewModel>()
            {
                new DiceButtonViewModel(1,new Small(){ Odds =1 }){Text1="Small"},
                new DiceButtonViewModel(2,new DoubleDice(1){ Odds =11}){Text1="1 Double",DiceControl= new Dice1ViewModel() },
                new DiceButtonViewModel(3,new DoubleDice(2){ Odds =11}){Text1="2 Double",DiceControl= new Dice2ViewModel()},
                new DiceButtonViewModel(4,new DoubleDice(3){ Odds =11}){Text1="3 Double",DiceControl= new Dice3ViewModel()},
                new DiceButtonViewModel(5,new TripleDice(1){ Odds =180}){Text1="1 Triple",DiceControl= new Dice1ViewModel()},
                new DiceButtonViewModel(6,new TripleDice(2){ Odds =180}){Text1="2 Triple",DiceControl= new Dice2ViewModel()},
                new DiceButtonViewModel(7,new TripleDice(3){ Odds =180}){Text1="3 Triple",DiceControl= new Dice3ViewModel()},
                new DiceButtonViewModel(8,new TripleDice(true){ Odds =30}){Text1="Triple"},
                new DiceButtonViewModel(9,new TripleDice(4){ Odds =180}){Text1="4 Triple" ,DiceControl= new Dice4ViewModel()},
                new DiceButtonViewModel(10,new TripleDice(5){ Odds =180}){Text1="5 Triple",DiceControl= new Dice5ViewModel()},
                new DiceButtonViewModel(11,new TripleDice(6){ Odds =180}){Text1="6 Triple",DiceControl= new Dice6ViewModel()},
                new DiceButtonViewModel(12,new DoubleDice(4){ Odds =11}){Text1="4 Double",DiceControl= new Dice4ViewModel()},
                new DiceButtonViewModel(13,new DoubleDice(5){ Odds =11}){Text1="5 Double",DiceControl= new Dice5ViewModel()},
                new DiceButtonViewModel(14,new DoubleDice(6){ Odds =11}){Text1="6 Double",DiceControl= new Dice6ViewModel()},
                new DiceButtonViewModel(15,new Big(){ Odds =1 }){Text1="Big"},
                new DiceButtonViewModel(16,new TotalDicePoints(4){ Odds=60}){Text1="4",Text2="1 wins 60"},
                new DiceButtonViewModel(17,new TotalDicePoints(5){ Odds=20}){Text1="5",Text2="1 wins 20"},
                new DiceButtonViewModel(18,new TotalDicePoints(6){ Odds=18}){Text1="6",Text2="1 wins 18"},
                new DiceButtonViewModel(19,new TotalDicePoints(7){ Odds=12}){Text1="7",Text2="1 wins 12"},
                new DiceButtonViewModel(20,new TotalDicePoints(8){ Odds=8}){Text1="8",Text2="1 wins 8"},
                new DiceButtonViewModel(21,new TotalDicePoints(9){ Odds=6}){Text1="9",Text2="1 wins 6"},
                new DiceButtonViewModel(22,new TotalDicePoints(10){ Odds=6}){Text1="10",Text2="1 wins 6"},
                new DiceButtonViewModel(23,new TotalDicePoints(11){ Odds=6}){Text1="11",Text2="1 wins 6"},
                new DiceButtonViewModel(24,new TotalDicePoints(12){ Odds=6}){Text1="12",Text2="1 wins 6"},
                new DiceButtonViewModel(25,new TotalDicePoints(13){ Odds=8}){Text1="13",Text2="1 wins 8"},
                new DiceButtonViewModel(26,new TotalDicePoints(14){ Odds=12}){Text1="14",Text2="1 wins 12"},
                new DiceButtonViewModel(27,new TotalDicePoints(15){ Odds=18}){Text1="15",Text2="1 wins 18"},
                new DiceButtonViewModel(28,new TotalDicePoints(16){ Odds=20}){Text1="16",Text2="1 wins 20"},
                new DiceButtonViewModel(29,new TotalDicePoints(17){ Odds=60}){Text1="17",Text2="1 wins 60"},
                new DiceButtonViewModel(30,new TwoDicePoints(1,2)){Text1="1 and 2",DiceControl= new Dice1ViewModel(),DiceControl1= new Dice2ViewModel()},
                new DiceButtonViewModel(31,new TwoDicePoints(1,3)){Text1="1 and 3",DiceControl= new Dice1ViewModel(),DiceControl1= new Dice3ViewModel()},
                new DiceButtonViewModel(32,new TwoDicePoints(1,4)){Text1="1 and 4",DiceControl= new Dice1ViewModel(),DiceControl1= new Dice4ViewModel()},
                new DiceButtonViewModel(33,new TwoDicePoints(1,5)){Text1="1 and 5",DiceControl= new Dice1ViewModel(),DiceControl1= new Dice5ViewModel()},
                new DiceButtonViewModel(34,new TwoDicePoints(1,6)){Text1="1 and 6",DiceControl= new Dice1ViewModel(),DiceControl1= new Dice6ViewModel()},
                new DiceButtonViewModel(35,new TwoDicePoints(2,3)){Text1="2 and 3",DiceControl= new Dice2ViewModel(),DiceControl1= new Dice3ViewModel()},
                new DiceButtonViewModel(36,new TwoDicePoints(2,4)){Text1="2 and 4",DiceControl= new Dice2ViewModel(),DiceControl1= new Dice4ViewModel()},
                new DiceButtonViewModel(37,new TwoDicePoints(2,5)){Text1="2 and 5",DiceControl= new Dice2ViewModel(),DiceControl1= new Dice5ViewModel()},
                new DiceButtonViewModel(38,new TwoDicePoints(2,6)){Text1="2 and 6",DiceControl= new Dice2ViewModel(),DiceControl1= new Dice6ViewModel()},
                new DiceButtonViewModel(39,new TwoDicePoints(3,4)){Text1="3 and 4",DiceControl= new Dice3ViewModel(),DiceControl1= new Dice4ViewModel()},
                new DiceButtonViewModel(40,new TwoDicePoints(3,5)){Text1="3 and 5",DiceControl= new Dice3ViewModel(),DiceControl1= new Dice5ViewModel()},
                new DiceButtonViewModel(41,new TwoDicePoints(3,6)){Text1="3 and 6",DiceControl= new Dice3ViewModel(),DiceControl1= new Dice6ViewModel()},
                new DiceButtonViewModel(42,new TwoDicePoints(4,5)){Text1="4 and 5",DiceControl= new Dice4ViewModel(),DiceControl1= new Dice6ViewModel()},
                new DiceButtonViewModel(43,new TwoDicePoints(4,6)){Text1="4 and 6",DiceControl= new Dice4ViewModel(),DiceControl1= new Dice6ViewModel()},
                new DiceButtonViewModel(44,new TwoDicePoints(5,6)){Text1="5 and 6",DiceControl= new Dice5ViewModel(),DiceControl1= new Dice6ViewModel()},
                new DiceButtonViewModel(45,new SingleDicePoints(1)){Text1="ONE",DiceControl= new Dice1ViewModel()},
                new DiceButtonViewModel(46,new SingleDicePoints(2)){Text1="TWO",DiceControl= new Dice2ViewModel()},
                new DiceButtonViewModel(47,new SingleDicePoints(3)){Text1="THREE",DiceControl= new Dice3ViewModel()},
                new DiceButtonViewModel(48,new SingleDicePoints(4)){Text1="FOUR",DiceControl= new Dice4ViewModel()},
                new DiceButtonViewModel(49,new SingleDicePoints(5)){Text1="FIVE",DiceControl= new Dice5ViewModel()},
                new DiceButtonViewModel(50,new SingleDicePoints(6)){Text1="SIX",DiceControl= new Dice6ViewModel()}

            };

            return list;
        }
        public WinFuction WinFuction{get;}

        public ICommand BetClickCommand { get; }
        public DiceButtonViewModel(int number, WinFuction win)
        {
            WinFuction = win;
            Number = number;
            Bet = new BetPoco(number);
            BetClickCommand = new TsCommand(BetClickExecute);
        }

        private void BetClickExecute()
        {
            var unit = 2;
            var totalPoint = MainwindowViewModel.GetInstance().User.Points;
            decimal bet = 0;
            if (totalPoint > 0)
            {
                if (totalPoint > unit)
                {
                    bet = unit;                    
                }
                else
                {
                    bet = totalPoint - unit;                   
                }                
           
                MainwindowViewModel.GetInstance().User.MinusPoints(bet);
                MainwindowViewModel.GetInstance().RefreshPoints();
                MainwindowViewModel.GetInstance().Bets += bet;
                Bet.AddBets(bet);
            }
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

        public object DiceControl
        {
            get { return _DiceControl; }
            set
            {
                _DiceControl = value;
                OnPropertyChanged();
            }
        }
        private object _DiceControl;
        public object DiceControl1
        {
            get { return _DiceControl1; }
            set
            {
                _DiceControl1 = value;
                OnPropertyChanged();
            }
        }
        private object _DiceControl1;
    }
}
