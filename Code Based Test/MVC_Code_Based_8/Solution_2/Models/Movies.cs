﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Solution_2.Models
{
    public class Movies
    {
        [Key]
        public int Mid { get; set; }

        [Required]
        public string Moviename { get; set; }

        [Required]
        public DateTime DateofRelease { get; set; }
    }
}