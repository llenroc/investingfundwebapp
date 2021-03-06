﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvestingApp.Database.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public double Benefit { get; set; }
        public DateTime LastAttemptTime { get; set; }
        public int LoginAttempts { get; set; }
    }
}