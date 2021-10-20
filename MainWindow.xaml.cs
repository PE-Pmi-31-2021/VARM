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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding binding = new Binding();
            binding.ElementName = "MainFrame1";
            binding.Path = new PropertyPath("Source");

            MainFrame.SetBinding(Frame.SourceProperty, binding);


            //MainFrame.Source = new Uri("pack://application:,,,/VARM games TEST;component/Game1.xaml");
            MainFrame.Source = new Uri("pack://application:,,,/VARM games TEST;component/Views/MainPage.xaml");
        }
    }
}
