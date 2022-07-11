using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setupGame();
        }

        private void setupGame()
        {
            List<string> list = new List<string>()
            {
                "🐯","🐮","🐏","🐶",
                "🦝","🐴","🦌","🐫",
                "🐯","🐮","🐏","🐶",
                "🦝","🐴","🦌","🐫",
                "🐭","🐼","🐭","🐼"
            };
            Random rand = new Random();
            foreach (TextBlock x in grid.Children.OfType<TextBlock>())
            {
                int index = rand.Next(list.Count);
                string animal = list[index];
                x.Text = animal;
                list.RemoveAt(index);
            }
        }
    }
}
