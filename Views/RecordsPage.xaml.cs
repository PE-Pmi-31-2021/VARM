using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        public RecordsPage()
        {
            InitializeComponent();
            using (var db = new Model1())
            {

                //var Game1 = new Game { title = "Tic-Tac-Toe", gid = 1000 };
                //var Game2 = new Game { title = "Sea Battle", gid = 2000 };
                //var Game3 = new Game { title = "Memory", gid = 3000 };
                //db.games.Add(Game1);
                //db.games.Add(Game2);
                //db.games.Add(Game3);
                //var Player1 = new Player { name = "First", id = 1000 };
                //var Player2 = new Player { name = "Second", id = 2000 };
                //var Player3 = new Player { name = "Third", id = 3000 };
                //db.players.Add(Player1);
                //db.players.Add(Player2);
                //db.players.Add(Player3);
                //var Record1 = new Record { gid = 1000, id = 1000, rec = 54, rec_id = 1 };
                //var Record2 = new Record { gid = 2000, id = 2000, rec = 64, rec_id = 2 };
                //var Record3 = new Record { gid = 3000, id = 3000, rec = 543, rec_id = 3 };
                //db.records.Add(Record1);
                //db.records.Add(Record2);
                //db.records.Add(Record3);
                //db.SaveChanges();
                db.games.Load();
                db.records.Load();
                db.players.Load();

                var query = from b in db.games
                            orderby b.title
                            select b;
                var query1 = from b in db.players
                            orderby b.name
                            select b;
                var query2 = from b in db.records
                             orderby b.rec
                             select b;
                List<Output> o = new List<Output>();
                recordsGrid.ItemsSource = db.games.Local;
            }


        }

        private void recordsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage g = new MainPage();
            this.NavigationService.Navigate(g);
        }
    }
    public class Output
    {
        public string name { get; set; }
        public string title { get; set; }
        public int record { get; set; }
        public Output(string n, string t, int r)
        {
            n = name;
            t = title;
            r = record;
        }
    }
}
