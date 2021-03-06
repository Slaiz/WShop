﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    /// <summary>
    /// Model of DB
    /// </summary>
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string MainPlatform { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } 
    }
}
