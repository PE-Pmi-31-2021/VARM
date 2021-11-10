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
using Npgsql;

namespace LNU_VARM_games
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            var cs = "Host=localhost;Username=postgres;Password=P_ost38246_gre7s_ql;Database=VARM";
            var con = new NpgsqlConnection(cs);
            con.Open();

            InitializeComponent();
            Binding binding = new Binding();
            binding.ElementName = "MainFrame1";
            binding.Path = new PropertyPath("Source");

            MainFrame.SetBinding(Frame.SourceProperty, binding);


            //MainFrame.Source = new Uri("pack://application:,,,/VARM games TEST;component/Game1.xaml");
            MainFrame.Source = new Uri("pack://application:,,,/VARM games TEST;component/Views/MainPage.xaml");
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
