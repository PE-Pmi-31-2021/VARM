using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VARM_games_TEST.Models
{
    public class Record
    {
        [Key]
        public int rec_id { get; set; }
        public int rec { get; set; }
        public int id { get; set; }
        public int gid { get; set; }
        public virtual List<Game> Games { get; set; }
        public virtual List<Player> Players { get; set; }
    }
}
