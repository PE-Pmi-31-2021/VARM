using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARM_games_TEST.Models
{
    public class Games
    {
        public string title { get; set; }
        [Key]
        public int g_id { get; set; }
    }
}
