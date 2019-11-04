using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiceGame
{
    /// <summary>
    /// DiceButton.xaml 的互動邏輯
    /// </summary>
    public class DiceButton : Button
    {
        static DiceButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DiceButton), new FrameworkPropertyMetadata(typeof(DiceButton)));
        }
        public DiceButton()
        {
            
        }
        public string DiceBets
        {
            get
            {
                return (string)GetValue(DiceBetsProperty);
            }
            set
            {
                SetValue(DiceBetsProperty, value);
            }
        }
        public static readonly DependencyProperty DiceBetsProperty = DependencyProperty.Register("DiceBets", typeof(string), typeof(DiceButton),
          new FrameworkPropertyMetadata("0",FrameworkPropertyMetadataOptions.BindsTwoWayByDefault ));
    }
}