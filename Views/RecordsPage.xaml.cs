using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NLog;
using VARM_games_TEST.Models;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Npgsql;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using LNU_VARM_games;

namespace VARM_games_TEST.Views
{
    /// <summary>
    /// Interaction logic for RecordsPage.xaml
    /// </summary>
    public partial class RecordsPage : Page
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public RecordsPage()
        {
            InitializeComponent();
            using (var db = new Model1())
            {
                db.games.Load();
                db.records.Load();
                db.players.Load();
                logger.Debug("Records table opened");
                var players = db.players.Local.ToList();
                foreach (var b in players) { Console.WriteLine("----research"+Convert.ToString(b)+"\n"); }
                
                recordsGrid.ItemsSource = db.players.Local;
                recordsGrid_Copy.ItemsSource = db.games.Local;
                recordsGrid_Copy1.ItemsSource = db.records.Local;
            }


        }

        private void recordsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage g = new MainPage();
            this.NavigationService.Navigate(g);
            logger.Debug("Records to MainPage");
        }
    }
    //public class Output
    //{
    //    public string name { get; set; }
    //    public string title { get; set; }
    //    public int record { get; set; }
    //    public Output(string n, string t, int r)
    //    {
    //        n = name;
    //        t = title;
    //        r = record;
    //    }
    //}
}
