﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Quiz335.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
