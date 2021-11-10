using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARM_games_TEST.Models
{
    class Records
    {
        [Key]
        public int id { get; set; }
        [Key]
        public int g_id { get; set; }
        public int record { get; set; }
    }
}
