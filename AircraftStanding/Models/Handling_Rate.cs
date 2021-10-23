﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftStanding.Models
{
    public class Handling_Rate
    {
        [Key]
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
