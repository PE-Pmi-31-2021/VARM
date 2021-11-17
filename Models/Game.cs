using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VARM_games_TEST.Models
{
    public class Game
    {
        [Key]
        public int gid { get; set; }
        public string title { get; set; }
        public virtual Record Record { get; set; }
    }
}
