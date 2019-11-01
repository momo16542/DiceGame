using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class MainwindowViewModel:ViewModelBase
    {

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
            dic
        }
    }
}
