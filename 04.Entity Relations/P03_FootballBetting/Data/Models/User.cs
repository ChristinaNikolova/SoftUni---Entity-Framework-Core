﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class User
    {
        public User()
        {
            this.Bets = new HashSet<Bet>();
        }
        public int UserId { get; set; }


        [Required]
        [MaxLength(100)]
        public string Username { get; set; }


        [Required]
        [MaxLength(200)]
        public string Password { get; set; }


        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }
    }
}
