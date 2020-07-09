﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class Position
    {
        public Position()
        {
            this.Players = new HashSet<Player>();
        }
        public int PositionId { get; set; }


        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
