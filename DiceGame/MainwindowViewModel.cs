using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceGame
{
    class MainwindowViewModel : ViewModelBase
    {
        public string Game
        {
            get { return $"Game{GameCount}"; }

        }


        public int GameCount
        {
            get { return _GameCount; }
            set
            {
                _GameCount = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Game));
            }
        }
        private int _GameCount = 1;

        public decimal Bets
        {
            get { return _Bets; }
            set
            {
                _Bets = value;
                OnPropertyChanged();
            }
        }
        private decimal _Bets;

        public decimal Points
        {
            get { return _Points; }
            set
            {
                _Points = value;
                OnPropertyChanged();
            }
        }
        private decimal _Points;

        public ICommand DepositCommand
        {
            get { return _DepositCommand; }
            set
            {
                _DepositCommand = value;
                OnPropertyChanged();
            }
        }
        private ICommand _DepositCommand;

        public ICommand RollCommand
        {
            get
            {
                return _RollCommand;
            }
            set
            {
                _RollCommand = value;
                OnPropertyChanged();
            }
        }
        private ICommand _RollCommand;
        public ICommand WithdrawCommand
        {
            get { return _WithdrawCommand; }
            set
            {
                _WithdrawCommand = value;
                OnPropertyChanged();
            }
        }
        private ICommand _WithdrawCommand;

        public User User { get; }
        public ObservableCollection<string> Results { get; }
        public List<DiceButtonViewModel> DiceButtons
        {
            get { return _DiceButtons; }
            set
            {
                _DiceButtons = value;
                OnPropertyChanged();
            }
        }
        private List<DiceButtonViewModel> _DiceButtons;
        public MainwindowViewModel()
        {
            User = new User();
            DiceButtons = DiceButtonViewModel.GetDiceButtonsViewModels();
            RollCommand = new TsCommand(RollExecute);
            DepositCommand = new TsCommand(DepositExecute);
            WithdrawCommand = new TsCommand(WithdrawExecute);
            Results = new ObservableCollection<string>();
        }

        private void WithdrawExecute()
        {
            User.WithdrawPoints();
            RefreshPoints();
        }

        private void DepositExecute()
        {
            User.AddPoints(1000);
            RefreshPoints();
        }

        private void RollExecute()
        {
            if (Bets == 0)
            {
                return;
            }

            Dice dice = new Dice();
            decimal bonus = 0;
            var dicePoint = dice.DrawDice();
            Results.Add($"{Game} :  {dicePoint[0]} , {dicePoint[1]} , {dicePoint[2] } | {dicePoint.Sum()}");

            foreach (var item in DiceButtons)
            {

                bonus += dice.DistributeBonus(dicePoint, item.WinFuction, item.Bet);
                item.Bet.ClearBets();
            }
            User.AddPoints(bonus);
            RefreshPoints();
            GameCount++;
            Bets = 0;

        }

        private static MainwindowViewModel mainwindowViewModel;
        public static MainwindowViewModel GetInstance()
        {
            if (mainwindowViewModel == null)
            {
                mainwindowViewModel = new MainwindowViewModel();
            }
            return mainwindowViewModel;
        }

        internal void RefreshPoints()
        {
            Points = User.Points;
        }
    }
}
