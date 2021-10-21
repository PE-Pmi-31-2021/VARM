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

namespace LNU_VARM_games
{
    /// <summary>
    /// Interaction logic for Game1.xaml
    /// </summary>
    public partial class Game1 : Page
    {
        public Game1()
        {
            InitializeComponent();
        }

        private void Return_to_main_menu_button_click(object sender, RoutedEventArgs e)
        {

            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);

            //MainFrame.Source = new Uri("pack://application:,,,/VARM games TEST;component/Game1.xaml");
            //MainWindow mw = new MainWindow();
            //this.Content = this;

            //NavigationService.Navigate(new MainWindow());
            //MainWindow m_win = new MainWindow();
            //m_win.Owner = this;
            //m_win.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //m_win.Show();

            //m_win.Owner = null;
            //this.Close();
        }

        private void Play_button_click(object sender, RoutedEventArgs e)
        {

        }


    }
}
