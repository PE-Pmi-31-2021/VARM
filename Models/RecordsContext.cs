using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace VARM_games_TEST.Models
{
    class RecordsContext : DbContext
    {
        public DbSet<Games> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Records> Records { get; set; }
    }
}