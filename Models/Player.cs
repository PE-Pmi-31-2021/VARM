﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VARM_games_TEST.Models
{
    public class Player
    {
        public string name { get; set; }
        [Key]
        public int id { get; set; }
        public virtual Record Record { get; set; }
    }
}
