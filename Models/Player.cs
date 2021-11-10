using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARM_games_TEST.Models
{
    class Player
    {
        public string name { get; set; }
        [Key]
        public int id { get; set; }
        public string password { get; set; }
    }
}
