using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
using VARM_games_TEST.Models;

namespace VARM_games_TEST.Views
{
    /// <summary>
    /// Interaction logic for RecordsPage.xaml
    /// </summary>
    public partial class RecordsPage : Page
    {
        RecordsContext db;
        public RecordsPage()
        {
            InitializeComponent();
            db = new RecordsContext();
            db.Players.Load();
            db.Games.Load();
            db.Records.Load();

            //string sqlString = "SELECT \"Player\".name, \"Player\".id, \"Games\".title, \"Records\".record from \"Records\"" +
            //    "join \"Player\" on (\"Player\".id = \"Records\".id) join \"Games\" on (\"Games\".g_id = \"Records\".g_id)";

            //var query = from r in db.Records
            //            join g in db.Games on r.g_id equals g.g_id
            //            join p in db.Players on r.id equals p.id
            //            select new
            //            {
            //                player = p.name,
            //                game = g.title,
            //                record = r.record
            //            };

            //recordsGrid.ItemsSource = query;


        }

        private void recordsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
