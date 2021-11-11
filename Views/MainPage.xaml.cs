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
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.ElementName = "MainFrame1";
            binding.Path = new PropertyPath("Source");


            Game1 g = new Game1();
            this.NavigationService.Navigate(g);
        }
    }
}
