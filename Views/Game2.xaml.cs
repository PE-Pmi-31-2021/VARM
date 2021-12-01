using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using VARM_games_TEST.Views;

namespace LNU_VARM_games
{
    public partial class Game2 : Page
    {
        public Game2()
        {
            InitializeComponent();
        }

        private void Score_button_click(object sender, RoutedEventArgs e)
        {

            //ScorePage Page = new ScorePage();
            //this.NavigationService.Navigate(Page);
        }

        private void Play_button_click(object sender, RoutedEventArgs e)
        {

            MemPairs mp = new MemPairs();
            this.NavigationService.Navigate(mp);
        }

        private void Home_click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
    }
}
